// using Firebase;
// using Firebase.Database;
// using Firebase.Unity.Editor;
// using System.Collections;
// using UnityEngine;

//  public class UserNameSaver : MonoBehaviour
//  {
//     public InputField usernameInput;

//     void Start()
//     {
//         // Initialize Firebase
//         FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://dinocoding-77ff9-default-rtdb.firebaseio.com/");
//     }

//     public async Task SaveUsernameToFirebase()
//     {
//         // Retrieve the user-entered username
//         string username = usernameInput.text;

//         // Create a reference to the location in the Firebase database where you want to save the username
//         DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("usernames");

//         // Save the username to the specified location in the Firebase database
//         await reference.SetValueAsync(username);
//     }
// }

