# NoxiousPluKsYesNoBot
A simple Telegram bot that responds to /yesno

Also works in groups

## Requirements
* .NET 5.x
* Any OS that runs .NET 5.x (Linux, Windows, Mac OS, whatever)

## Setup bot
* Create a new bot in Botfather
* /setcommands
`yesno - Get a random yes or no`
* /setprivacy 
`DISABLED` (or it will only work in PM, or in supergroups where it is admin)
* Put the API code you got in [Program.cs](Program.cs)
* Type `dotnet run` to start the bot
