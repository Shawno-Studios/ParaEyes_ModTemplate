# ParaEyes_ModTemplate
A mod template for ParaEyes

## How to use this?
Click the big "Use this template" button at the top of the page. Follow the prompts to create the template. Open the template with Github Desktop, then open "ParaEyes_ModTempalte.sln" with Visual Studio. Fill out the "modName", "modVersion", and "modAuthor" variables. Also, fill out the line that says this: ```[BepInPlugin("modAuthor.modName", "modName", "modVersion")]``` . Following this, go to the Solution Explorer and open the "dependencies.targets" file. Change the "GameDirectory" line at the top to be the filepath to the game on your PC. The last step you need to do is rename the project to whatever you want your mod to be called. This sets the name of the actual mod file so it's an important step. After this you're done and ready to go. Start making your mod and when you're ready to test it, just build it and it will automatically be copied to the game's mods folder.

Discord: 
https://discord.com/invite/w3JNgK3HXk
