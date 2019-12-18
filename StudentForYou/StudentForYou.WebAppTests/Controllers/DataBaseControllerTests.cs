using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Controllers;
using StudentForYou.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
namespace StudentForYou.WebApp.Controllers.Tests
{
    [TestClass()]
    public class DataBaseControllerTests
    {
        Course testCourse;
        Func<string, string, int, Course> CreateTestCourse = delegate (string testname, string testdescription, int testdifficulty)
             {
                 var tCourse = new Course();
                 tCourse.CourseName = testname;
                 tCourse.CourseDescription = testdescription;
                 tCourse.CourseDifficulty = testdifficulty;
                return tCourse;

            };

        [TestMethod()]
        public void PutCourseTest()
        {  
            int expectedDifficulty = 5;
            string expectedName = "testcourse";
            string expectedDescription = "this is a test course";
            var testCourse = CreateTestCourse(expectedName, expectedDescription, expectedDifficulty);


             var controller = new DataBaseController();
                using (TransactionScope ts = new TransactionScope())
                {   
                   
                    var courseController = new CourseController();
                    courseController.PostCourse(testCourse);
                    var testingList = courseController.GetCourses();
                    Assert.IsTrue(
                    testingList.Exists(c => c.CourseName == expectedName && c.CourseDescription == expectedDescription && c.CourseDifficulty == expectedDifficulty)

                        );
                }
            
        }

        [TestMethod()]
        public void DeleteCourseTest()
        {
            var controller = new DataBaseController();
            var expectedDifficulty = 1;
            var expectedName = "deletecourse";
            var expectedDescription = "coursetotestdeletion";
        
          

            using (TransactionScope ts = new TransactionScope())
            {  
                testCourse = CreateTestCourse(expectedName, expectedDescription, expectedDifficulty);
                var courseController = new CourseController();
                courseController.PostCourse(testCourse);
                var testingList = courseController.GetCourses();
                foreach (Course c in testingList)
                {

                    if (c.CourseName == expectedName && c.CourseDescription == expectedDescription && c.CourseDifficulty == expectedDifficulty)
                    {
                        var idForTestDeletion = c.CourseID;

                        courseController.DeleteCourse(idForTestDeletion);
                        break;

                    }

                }
                Assert.IsFalse(
                testingList.Exists(c => c.CourseName == expectedName && c.CourseDescription == expectedDescription && c.CourseDifficulty == expectedDifficulty)

                    );
            }

        }
        [TestMethod()]
        public void PostReviewTest()
        {
            var courseController = new CourseController();
          
            using (TransactionScope ts = new TransactionScope())
            {
                 testCourse = CreateTestCourse("reviewtestcourse", "test", 5);
                courseController.PostCourse(testCourse);
                var testingList = courseController.GetCourses();
                foreach(Course c in testingList)
                {
                    if(c.CourseName == "reviewtestcourse" && c.CourseDescription == "test" && c.CourseDifficulty == 5)
                    {
                        testCourse = c;
                        Console.WriteLine(testCourse.CourseID);
                    }
                }
                var testReview = new Review();
                testReview.CourseID = testCourse.CourseID;
                testReview.ReviewText = "test review text";
                courseController.PostReview(testReview);
                var reviewTestList = courseController.GetReviews(testCourse.CourseID);
                var expectedReviewText = "test review text";

                Assert.IsTrue(reviewTestList.Exists(r => r.ReviewText == expectedReviewText));
         
            }

        }
        [TestMethod()]

        public void RegexTest()
        {
            var spaceRemover = new WhiteSpaceRemover();
            var tCourse = CreateTestCourse("abab   aabb   aaa", "lala    aaa   aa", 5);
            var tuple = WhiteSpaceRemover.CleanCourseBeforePost(tCourse.CourseName, tCourse.CourseDescription);
            var cleanString1 = tuple.Result.Item1;
            var cleanString2 = tuple.Result.Item2;
            Assert.IsTrue(cleanString1 == "abab aabb aaa" && cleanString2== "lala aaa aa");
               
        }

    }




    }




        
    
