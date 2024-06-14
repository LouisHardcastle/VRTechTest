# Unity VR Test

Create a simple simulation in VR, that allows a user to connect 2 items together, notifying them when they've succeeded.

## Requirements

- The scene can be a simple white card model (e.g. a white cube), or a more complex scene from e.g. https://sketchfab.com/
- The interactions must occur within VR, using a target headset of your choice between Quest, HTC or Pico
- The 2 objects that you join together can be anything - simple geometric shapes, or more complex models from e.g. https://sketchfab.com/
- The 2 objects must join together and stay joined together
- The 2 objects must spawn on a table, or a table-height equivalent
- If the objects are dropped, they must respawn on the table
- The scene should contain instructions on what the user needs to do
- When the interaction is completed, the user should be notified visually and via an audio cue - there are some good cues available at https://developer.oculus.com/downloads/package/oculus-audio-pack-1/
- If flashy graphics are not your thing, don't worry. For this assignment, function is more important than form

### General guidance

- It's acceptable for this to only target a single VR headset. If you do not have a headset, then please demo using [XR Device Simulator](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/manual/xr-device-simulator-overview.html) or similar
- You should use engineering best practices where appropriate. Principles we value include: performance, readability, testability, scalability, simplicity. You should also aim to achieve a clean separation of concerns between components of your solution
- Please use git, and commit often so that we're able to see the stages you went through when approaching the problem
- Do not spend more than 3 hours on this. If you are unable to finish, then consider writing some notes on how you would have proceeded
- We're assessing **your** ability to program. Please no copy/pasting or use of AI

### Bonus points

- Use [conventional commits](https://www.conventionalcommits.org/en/v1.0.0/)
- Write up a README with information on how to build / run and information on the approach

### Submission

- Either zip up your solution (including the .git folder) and send over, or share a link to a repository on a cloud git service, such as Github, Gitlab or Bitbucket.
- Provide a screencast of the simulation and include with your submission
