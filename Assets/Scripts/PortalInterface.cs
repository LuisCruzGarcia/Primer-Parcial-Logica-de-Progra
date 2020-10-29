using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public interface PortalInterface
{
    void Initialize();
    void getAnswer(InputField answerField);
    void goToHub();
}
