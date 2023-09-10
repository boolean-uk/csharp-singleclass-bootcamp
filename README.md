#Bootcamp Academy

1. As a student of the Academy I want to be able to add a specific course to my Learning Plan.

2. As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.

3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.

4. As a manager at the Academy, I'd like to be able to change the capacity of Learning Plans.

5. As a student of the Academy, I'd like to know that if I try to remove an item that doesn't exist in my Learning Plan.


#Domain Models In Here   

```
1. As a student of the Academy I want to be able to add a specific course to my Learning Plan.
```
| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`BootCampAcademy`| `Add(string course)`                               | add course to List<strig> member| bool             |




2. As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.
```
| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`BootCampAcademy`| `Remove(int id)`                                   | If product is in list, add cost | bool             |
```



3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.
```
| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`BootCampAcademy`|  public int LearningPlanMax { get; set; } = 3;     | propety to set max number       | int number       |
|`BootCampAcademy`|  public bool LearningPlanIsFull                    | property check full status      | bool             |
|`BootCampAcademy`| `Add(string course)` modify method to check if full| add course to List<strig> member| bool             |
```



4. As a manager at the Academy, I'd like to be able to change the capacity of Learning Plans.
```
| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`BootCampAcademy`|  public int LearningPlanMax { get; set; } = 3;     | propety to set max number       | int number       |
```



5. As a student of the Academy, I'd like to know that if I try to remove an item that doesn't exist in my Learning Plan.
```
| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`BootCampAcademy`| `Remove(int id)`                                   | If product is in list, add cost | bool             |
```
