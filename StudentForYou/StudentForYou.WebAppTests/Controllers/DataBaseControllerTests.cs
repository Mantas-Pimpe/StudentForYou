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
        Func<string, string, int, Course> CreateTestCourse = delegate (string name, string description, int difficulty)
             {
                 var tCourse = new Course();
                 tCourse.CourseDescription = name;
                 tCourse.CourseDescription = description;
                 tCourse.CourseDifficulty = difficulty;
                return tCourse;

            };

        [TestMethod()]
        public void PutCourseTest()
        {
            var controller = new DataBaseController();
            int expectedDifficulty = 5;
            string expectedName = "testcourse";
            string expectedDescription = "this is a test course";
           



            using (TransactionScope ts = new TransactionScope())
            {   var testCourse = CreateTestCourse(expectedName, expectedDescription, expectedDifficulty);
                Console.WriteLine(testCourse.CourseDescription);
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
            {  var testCourse = CreateTestCourse(expectedName, expectedDescription, expectedDifficulty);
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
                var testCourse = CreateTestCourse("reviewtestcourse", "test", 5);
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



    }




    }




        
    
