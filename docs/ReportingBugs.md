# Reporting a bug or crash

If the program crashes, it will attempt to generate a trace file called `DiscordAudioStream_stack_trace.txt`. This file will be located in the same folder as your executable (`DiscordAudioStream.exe`).
Create a [new issue](https://github.com/pol-rivero/DiscordAudioStream/issues/new) and make sure to attach your trace file to help me solve your crash more easily.

If the stack trace is not generated automatically, go to Settings [<img src="img/settings-light.png" align="top"></img>](#gh-light-mode-only)[<img src="img/settings-dark.png" align="top"></img>](#gh-dark-mode-only) > Debug and enable *Output log file*.
Close and reopen the program for this change to take effect.

When this option is active, your actions inside the program are logged to a file called `DiscordAudioStream_log.txt` (also located in the same folder as the executable).
Reproduce the crash (with the least number of steps, if possible) and send me the log file to help me locate the source of the crash. 

> **Privacy notice:** The logged information may include your Windows version, the resolution of your screen(s) and the name of the audio devices you are using. For privacy reasons, the titles/names of your opened windows/programs are **NOT** logged. The captured video/audio is **NOT** logged either. 
> 
> The logs never leave your computer unless you upload them, so feel free to read them and manually remove any unwanted information. Keep in mind that all files posted to GitHub issues can be read by anyone on the internet.
