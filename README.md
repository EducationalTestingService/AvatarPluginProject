# halef-avatar
For ETS

Purpose
-------
This project provides a WebGL package that depicts a 3D view of a man in a suit (aka "the avatar") seated at a desk in an office. Also in the package are animation clips depicting conversational gestures, and audio recordings of a male actor that can be played and which will lipsync with the avatar.

System Requirements
-------------------
For the avatar to become interactive, this package must be included in a website that is configured to place WebRTC phone calls to a HALEF environment. Furthermore, the environment must have a voice application deployed that implements the socket-based API that drives the avatar based on the user's speech transmitted over WebRTC and recognized by the voice application.

Build Method
------------
1. Clone this repo
1. Open the top-level folder of this project using the Unity3d IDE v5.6.2+
1. In Unity, go to File > Build Settings
1. In the top pane, verify that TitleScene and mainScene are listed
1. In the left pane, ensure that WebGL is the target platform
1. Ensure that Player Settings > Inspector > Other Settings > Optimization > Strip Engine Code = on
1. Click 'Build and Run'
1. When prompted for a local folder to save the build to, we recommend creating a 'builds' folder at the top-level of this project. We add this folder to our .gitignore
1. When the build is finished after several minutes, Unity will open WindowsExplorer to reveal the new folder. This folder must be copied to your website.

We intend to provide further instructions later.
