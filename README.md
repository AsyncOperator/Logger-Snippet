# Logger
***
**Logger** is a small snippet of code that acts as an extra layer on top of the **Debug** class already provided by Unity Engine.
### Features
***
Supports most [**`Debug`**](https://docs.unity3d.com/ScriptReference/Debug.html) class methods commonly used by developers.

* `Log`
* `LogWarning`
* `LogError`
* `DrawLine`
* `DrawRay`

### Usage
***
For the Logger to work, you must have defined the **`ENABLE_LOGGER`** directive in your project.
*In case you don't know how to add a directive*
1. Go to `Edit` > `Project Settings `
2. Then, under the `Player` tab group you will find the `Scripting Define Symbols`
3. Finally, add the **`ENABLE_LOGGER`** directive and *don't forget to Apply Changes*

### License
***
MIT