# Cybersecurity Awareness Bot

A simple console chatbot I built for ITPEP2 that teaches people about basic cyber threats. It chats with you, remembers what you've asked, and gives practical tips you can actually use.

I added a few extras like a voice greeting and typing effect to make it feel less like a boring console app and more like a real assistant.

## What it can do
- **Talks to you**: Greets you by name and holds a proper conversation until you type `exit`
- **Covers 3 main topics**: Phishing, passwords, and malware — with 3+ tips for each
- **Remembers context**: Won't repeat the same tip twice and reminds you what you've already covered
- **Handles mistakes**: If you type nothing or gibberish, it tells you how to fix it instead of crashing
- **Voice + visuals**: Plays a short `greeting.wav` on startup and uses ASCII art + color to look clean
- **Help command**: Type `help` anytime if you're stuck

## How to run it on your machine
1. Check you have .NET 6 installed: `dotnet --version`
2. Clone this repo: `git clone https://github.com/yakha714/CybersecurityAwarenessBot.git`
3. Go into the folder: `cd CybersecurityAwarenessBot`
4. Build: `dotnet build`
5. Run: `dotnet run`

If `greeting.wav` is missing it will just skip the sound and keep going. No crashes.

## How to use it
1. Launch the app and enter your name when it asks
2. Type a topic: `phishing`, `password`, or `malware`
3. Read the tip, then ask about another topic or type `help` to see options
4. Type `exit` or `quit` when you're done

## How I structured the code
| File | What it does |
| --- | --- |
| `Program.cs` | Starts the app, plays audio with error handling, launches the chatbot |
| `Chatbot.cs` | All the conversation logic, topic storage, user memory, input validation |
| `UIHelper.cs` | Handles the ASCII header and typing effect so `Program.cs` stays clean |
| `greeting.wav` | Short audio clip for the welcome message |
| `.csproj` | Project setup. Includes `System.Windows.Extensions` so `SoundPlayer` works |

I split it this way for separation of concerns — UI code is separate from chatbot logic. Makes it easier to test and mark.

## Tech & concepts used
- C# .NET 6
- OOP principles: encapsulation, single responsibility classes, readonly fields for data
- Error handling with `try/catch` and `File.Exists` checks
- `System.Media.SoundPlayer` for audio, `Thread.Sleep` for typing effect
- Collections: `Dictionary<string, string[]>` and `List<string>` for memory

## References
1. Microsoft. 2023. *SoundPlayer Class*. Microsoft Learn. https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer [Accessed 19 Apr 2026]. Used for implementing the startup audio greeting.
2. Microsoft. 2023. *Console Class*. Microsoft Learn. https://learn.microsoft.com/en-us/dotnet/api/system.console [Accessed 19 Apr 2026]. Used for all user input/output and text coloring.
3. Microsoft. 2022. *Thread.Sleep Method*. Microsoft Learn. https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep [Accessed 19 Apr 2026]. Referenced to create the typing effect in `UIHelper.cs`.
4. The Independent Institute of Education. 2026. *ITPEP2 Module Guide: Cybersecurity Awareness Bot Brief*. Used for project requirements and marking criteria.

## Author
Luyakha Ntshobane
ST10485641
The Independent Institute of Education – ITPEP2 2026
