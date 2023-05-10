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

        [Test]
        public void ChangeCapacity()
        {
            //4. As a manager at the Academy, I'd like to be able to change the capacity of Learning Plans.

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

            academy.ChangeCapacityLearningPlan(2);

            //assert
            Assert.AreEqual(academy.LearningPlans.Count, academy.LearningPlanMax);
        }

        [TestCase("Java")]
        public void ItemExists(string course)
        {
            //5. As a student of the Academy, I'd like to know that if I try to remove an item that doesn't exist in my Learning Plan.

            //arrange
            BootCampAcademy academy = new BootCampAcademy();
            string course2 = "Java";

            //act
            academy.AddToLearningPlan(course2);
            bool result = academy.RemoveFromLearningPlan(course);

            //assert
            Assert.IsTrue(result);
        }
    }
}