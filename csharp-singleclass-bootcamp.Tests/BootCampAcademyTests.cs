using csharp_singleclass_bootcamp.main;
using NUnit.Framework;

namespace csharp_singleclass_bootcamp.Tests
{
    [TestFixture]
    public class BootCampAcademyTests
    {
        [TestCase("C# for experts")]
        public void AddCourseToLearningPlan(string course)
        {
            //arrange
            BootCampAcademy academy = new BootCampAcademy();

            //act
            academy.AddToLearningPlan(course);

            //assert
            Assert.AreEqual(academy.LearningPlans.Count, 1);
        }


    }
}