# SysBot.NET-Mobile

### Q & A ###

**What is this?**

[SysBot.NET](https://github.com/kwsch/SysBot.NET) with a Xamarin.Forms frontend for the UI. Contains both the [SysBot.Pokemon](https://github.com/kwsch/SysBot.NET) and [SysBot.AnimalCrossing](https://github.com/kwsch/SysBot.AnimalCrossing) core.

Currently only works with Android, I don't own an iOS device.

**Is this fully functional?**

$info doesn't work due to no local file access. Everything else (including seedchecks now) *should* work. Make sure to view the logs tab after loading your config.

**Can I still use my device while this app is running?**

No, [Android no longer allows background execution of running tasks](https://docs.microsoft.com/en-gb/xamarin/android/app-fundamentals/services/#background-execution-limits-in-android-80), so the app must have focus at all times and your device shouldn't ever lock the screen while running (change the screen lock/sleep time to "never" in the settings of your device)

**Do I need to compile this myself?**

You should, but you can [download a prebuilt apk here.](https://berichan.github.io/GetNHSE/?org=berichan&proj=SysBot.NET-Mobile&projurl=https://github.com/berichan/SysBot.NET-Mobile)

**How do I use it?**

Transfer your config.json from your SysBot.exe folder to your mobile device (upload it somewhere like google drive then download it locally to your device) then hit the "load config.json" button in the app. All bots (besides YouTube for Pokemon) will start immediately.

**Is there any support for this/are you still working on it?**

No.

![img](https://i.imgur.com/zC00YQ4.png)
