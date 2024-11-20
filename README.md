# Discord Audio Stream

Windows utility that allows Discord to stream (with audio!) the entire desktop or a specific window (including an OBS composition).

Made out of necessity and continuous frustration. Built with WinForms (C#).


<p align="center">
    <img alt="Logo" src="DiscordAudioStream/resources/imgs/icon.svg" width="110">
</p>
<p align="center">
    <a href="https://github.com/pol-rivero/DiscordAudioStream/releases">
        <img alt="Total downloads" src="https://img.shields.io/github/downloads/pol-rivero/DiscordAudioStream/total?label=total%20downloads">
    </a>
    <a href="https://github.com/pol-rivero/DiscordAudioStream/releases">
        <img alt="Downloads of latest release" src="https://img.shields.io/github/downloads/pol-rivero/DiscordAudioStream/latest/total?label=downloads%20(latest%20release)">
    </a>
    <br>
    <a href="https://github.com/pol-rivero/DiscordAudioStream/issues">
        <img alt="Issues" src="https://img.shields.io/github/issues/pol-rivero/DiscordAudioStream">
    </a>
    <a href="https://github.com/pol-rivero/DiscordAudioStream/pulls">
        <img alt="Pull requests" src="https://img.shields.io/github/issues-pr/pol-rivero/DiscordAudioStream">
    </a>
    <a href="https://github.com/pol-rivero/DiscordAudioStream/blob/master/LICENSE">
        <img alt="License" src="https://img.shields.io/github/license/pol-rivero/DiscordAudioStream">
    </a>
</p>



## Who is this for?

If you use Discord regularly, you may be used to screen-sharing (streaming) a specific window. You may also have tried to stream the entire screen, only to realize that your friends cannot hear any audio from your desktop.

Similarly, you may be an advanced user who wants to step up your Discord streams by using OBS. While you can stream the OBS video output easily, it's not possible to stream the audio without configuring an advanced audio setup.

If any of these are true, this tool may be for you.


## Does it only work for Discord?

Not at all, you can use this tool with any video conferencing software that allows screen-sharing a specific window.

However, keep in mind that this utility has been built and tested only for Discord, so some of the steps below will be different and you may encounter errors.


## Does it only work on Windows?

Yes, this program uses Windows APIs that are not available on MacOS or Linux.


## Why is it licensed under GPLv3?

This program is a fork of [quick-screen-recorder](https://github.com/ModuleArt/quick-screen-recorder), by [ModuleArt](https://github.com/ModuleArt), which is licensed under the GPLv3 license.

Unfortunately, GPLv3 forces any derivative work to also be licensed under GPLv3, which means I'm unable to offer a more permissive license.


# How do I use it?

First, download the program from the [GitHub releases page](https://github.com/pol-rivero/DiscordAudioStream/releases). You should be able to execute it directly without installing anything.

The following steps depend on what you want to do.

**[Stream the entire desktop with audio](docs/StreamDesktop.md)**

**[Stream to Discord using OBS](docs/StreamOBS.md)**

---

## Advanced features

**Capture presets:** [Learn how to use them here](/docs/CapturePresets.md).

**Audio meter:** Once you start the stream, an audio meter will appear to let you know which audio is being captured and played back.
- You can hide/restore the audio meter in Settings [<img src="docs/img/settings-light.png" align="top"></img>](#gh-light-mode-only)[<img src="docs/img/settings-dark.png" align="top"></img>](#gh-dark-mode-only) or in the context menu (right-click the DiscordAudioStream window while streaming).

**Change capture method:** You can change which API is used for capturing video by going to Settings [<img src="docs/img/settings-light.png" align="top"></img>](#gh-light-mode-only)[<img src="docs/img/settings-dark.png" align="top"></img>](#gh-dark-mode-only) > Capture.
- Read [this document](/docs/CaptureMethods.md) for more information about the pros and cons of each method. 


## Reporting a bug/crash

See [this document](/docs/ReportingBugs.md) for instructions on how to report a bug or crash.
