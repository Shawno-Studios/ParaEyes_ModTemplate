# ParaEyes ModTemplate
A mod template for the horror game ParaEyes

## How to use this?

Using this mod template is easy. 
1. Download [BepInEx x64](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.21). We use this tool to run your mods. Once it's downloaded, extract all the files to your ParaEyes folder, the one where you installed it to. You can find it by opening your Steam Library, right clicking on the game, clicking on "Manage", then "Browse Local Files".
2. Click the big "Use this template" button at the top of the page. Follow the prompts to create the template. 
3. Download [Github Desktop](https://desktop.github.com/). This tool makes it easy to update any changes to your mod.
4. Open the template we made in step 2 (it can be found on your Github profile) and click the green "Code" button. Then click "Open with Github Desktop". This will download your mod to your PC.
5. When inside of Github Desktop, follow the prompts to download your mod. Then click the "Show In Explorer" button. This will open the File Explorer with all your mod's files.
6. Open "ParaEyes_ModTempalte.sln" file with Visual Studio.
7. All of your code will go in the MyMod.cs file. You can open it on the right of Visual Studio in the Solution Explorer. Fill out the "modName", "modVersion", and "modAuthor" variables. Also, fill out the line that says this: ```[BepInPlugin("modAuthor.modName", "modName", "modVersion")]``` .
8. Go to the Solution Explorer and open the "dependencies.targets" file. It can also be found in the File Explorer from step 5. Adjust the "GameDirectory" line at the top to be the filepath to the game on your PC. This is the folder you installed ParaEyes to (same as step 1).
9. The last step you need to do is rename the project to whatever you want your mod to be called. This sets the name of the actual mod file so it's an important step. 
10. You're done and ready to go. Start making your mod and when you're ready to test it, just build it and it will automatically be copied to the game's mods folder.

Discord: 
https://discord.com/invite/w3JNgK3HXk
