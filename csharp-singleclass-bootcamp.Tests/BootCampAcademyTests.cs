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


    }
}