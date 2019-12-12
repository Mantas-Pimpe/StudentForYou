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
        [TestMethod()]
        public void PutCourseTest()
        {
            var controller = new DataBaseController();

            Course testCourse = new Course();
            int expectedDifficulty = 5;
            string expectedName = "testcourse";
            string expectedDescription = "this is a test course";

            testCourse.CourseDifficulty = 5;
            testCourse.CourseName = "testcourse";
            testCourse.CourseDescription = "this is a test course";

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
            Course testCourse = new Course();
            int expectedDifficulty = 1;
            string expectedName = "deletecourse";
            string expectedDescription = "coursetotestdeletion";

            testCourse.CourseDifficulty = 1;
            testCourse.CourseName = "deletecourse";
            testCourse.CourseDescription = "coursetotestdeletion";

            using (TransactionScope ts = new TransactionScope())
            {
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
            Course testCourse = new Course();
            using (TransactionScope ts = new TransactionScope())
            {
                testCourse.CourseDifficulty = 5;
                testCourse.CourseName = "reviewtestcourse";
                testCourse.CourseDescription = "test";
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




        
    
