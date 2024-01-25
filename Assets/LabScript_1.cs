using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabScript_1 : MonoBehaviour
{
    public string courseName;

    //Assume everything is based on a 16 week course schedule with no breaks
    //Does not account for floating point, as scale is not large enough to matter

    const int COURSELENGTH = 16; //Maximum weeks in a course

    [Range(0, COURSELENGTH)]public int moduleCount;
    [Range(0, COURSELENGTH)]public int readingMatCount;
    [Range(0, COURSELENGTH)]public int assignmentCount;
    [Range(0, COURSELENGTH)]public int quizCount;
    public bool hasIntructorTaughtCourse;

    private float resultTotal = 0f;



    



    // 12/16 = x/30

    //
    // 15/100 = 




    
    void Start()
    {
        int instructorXpValue = 10;

        if(CheckAllZeros()) {
            Debug.LogError("This course is empty. Add something.");
            return;
        }
        if(hasIntructorTaughtCourse)
        {
           instructorXpValue = 0;
        }
        CalculateFactorPercentage(moduleCount, 15);
        CalculateFactorPercentage(readingMatCount, 30);
        CalculateFactorPercentage(quizCount, 15);
        CalculateFactorPercentage(assignmentCount, 30);

        Debug.LogFormat("Challenge Rating for course {0} is {1}", courseName, ((resultTotal+instructorXpValue)/10));

    }

    void CalculateFactorPercentage(int amountOfFactor, int factorPercentage)
    {
        resultTotal += ((float)amountOfFactor * (float)factorPercentage) / (float)COURSELENGTH;
        Debug.Log(resultTotal);
    }

    bool CheckAllZeros()
    {
        return moduleCount == 0 && assignmentCount == 0 && readingMatCount == 0 && quizCount == 0 && !hasIntructorTaughtCourse;
    }
    void CalcuateChallengeScore()
    {
        
    }

}
