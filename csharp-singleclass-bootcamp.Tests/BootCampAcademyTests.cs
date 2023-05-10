using csharp_singleclass_bootcamp.main;
using NUnit.Framework;
using System.Numerics;

namespace csharp_singleclass_bootcamp.Tests
{
    [TestFixture]
    public class BootCampAcademyTests
    {
        [TestCase("C# for experts")]
        public void AddCourseToLearningPlan(string course)
        {
            //1.As a student of the Academy I want to be able to add a specific course to my Learning Plan.

            //arrange
            BootCampAcademy academy = new BootCampAcademy();

            //act
            academy.AddToLearningPlan(course);

            //assert
            Assert.AreEqual(academy.LearningPlans.Count, 1);
        }

        [TestCase("C# for experts")]
        public void RemoveCourseFromLearningPlan(string course)
        {
            //2.As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.
            
            //arrange
            BootCampAcademy academy = new BootCampAcademy();
            academy.AddToLearningPlan(course);

            //act
            bool result = academy.RemoveFromLearningPlan(course);

            Assert.IsTrue(result);
            Assert.AreEqual(academy.LearningPlans.Count, 0);

        }

        [Test]
        public void FullLearningPlanTest()
        {
            //3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.
            //arrange
            BootCampAcademy academy = new BootCampAcademy();            
            
            string course1 = "C#";
            string course2 = "Java";
            string course3 = "Python";            
            string course4 = "C++";

            //act
            
            academy.AddToLearningPlan(course1);
            academy.AddToLearningPlan(course2);
            academy.AddToLearningPlan(course3);
            academy.AddToLearningPlan(course4);

            
            //assert
            Assert.AreEqual(academy.LearningPlans.Count, academy.LearningPlanMax);
            Assert.IsTrue(academy.LearningPlanIsFull);
        }

    }
}