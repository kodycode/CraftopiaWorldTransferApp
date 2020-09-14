# Craftopia World Transfer App

Simple WinForm application to transfer a Craftopia world from one saved file to another, as well as export a world as a .json file to import to another saved file.

**Requires .Net Core 3.0 to run**

## Instructions

**NOTE:** `SaveData.ocs` file is typically found in `<LetterDrive>:\Users\<Computer Username Here>\AppData\LocalLow\PocketPair\Craftopia\Save`

To import a world from one saved file to another:

1. Browse and select a source `SaveData.ocs` file
2. Browse and select a destination `SaveData.ocs` file
3. Select a world from the left list box
4. Click the Transfer button
5. The selected world should then be imported into the designated save file

If you just want to export a world to distribute:
1. Browse and select a source `SaveData.ocs` file
2. Select a world from the left list box
3. Click the Export button

You'll get a .json file with the name of your world, to which you can distribute to other people. If you want to import the world.json file to a saved file, follow the same steps as you would to import a world from one saved file to another.
