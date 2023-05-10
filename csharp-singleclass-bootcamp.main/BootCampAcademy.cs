namespace csharp_singleclass_bootcamp.main
{

    /*

Bootcamp Academy



1. As a student of the Academy I want to be able to add a specific course to my Learning Plan.


2. As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.

3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.

4. As a manager at the Academy, I'd like to be able to change the capacity of Learning Plans.


5. As a student of the Academy, I'd like to know that if I try to remove an item that doesn't exist in my Learning Plan.
     */
    public class BootCampAcademy
    {
        public void AddToLearningPlan(string course)
        {
            if(this.LearningPlans.Count < this.LearningPlanMax)
            {
                this.LearningPlans.Add(course);
            }
        }

        public bool RemoveFromLearningPlan(string course)
        {
            if (this.LearningPlans.Contains(course))
            {
                return this.LearningPlans.Remove(course);
            }
            return false;
        }

        public List<string> LearningPlans { get; set; } = new List<string>();
        public int LearningPlanMax { get; set; } = 3;
        public bool LearningPlanIsFull 
        {
            get 
            {
                return this.LearningPlanMax >= this.LearningPlans.Count ? true : false;               
            }         
        }

        public void ChangeCapacityLearningPlan(int max)
        {
            // if (user == manager) {
            LearningPlanMax = max;

            this.LearningPlans.RemoveRange(max, LearningPlans.Count - max);
        }
    }
}