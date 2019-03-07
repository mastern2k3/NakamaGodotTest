
# NakamaGodotTest
> An attempt to make a template for the Nakama gaming server C# client to work under Godot

## Where it's at
Currently apon trying to create the client object (e.g. `Nakama.Client`):
```
var client = new Nakama.Client("defaultkey", "localhost", 7350, true) {
    Timeout = 10000, // set timeout on requests (default is 5000).
    Retries = 5      // set retries on requests (default is 3).
};
```

I'm getting this message:

```
System.TypeInitializationException: The type initializer for 'System.Net.ServicePointManager' threw an exception. ---> System.Configuration.ConfigurationErrorsException: Error Initializing the configuration system. ---> System.MissingMethodException: string[] string.Split(char,System.StringSplitOptions)
  at System.Configuration.SectionGroupInfo.ReadRootData (System.Xml.XmlReader reader, System.Configuration.Configuration config, System.Boolean overrideAllowed) [0x00007] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.Configuration.ReadConfigFile (System.Xml.XmlReader reader, System.String fileName) [0x000ce] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.Configuration.Load () [0x00043] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.Configuration.Init (System.Configuration.Internal.IConfigSystem system, System.String configPath, System.Configuration.Configuration parent) [0x0005d] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.Configuration..ctor (System.Configuration.InternalConfigurationSystem system, System.String locationSubPath) [0x00056] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.Configuration..ctor (System.Configuration.InternalConfigurationSystem system, System.String locationSubPath) [0x00038] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.InternalConfigurationFactory.Create (System.Type typeConfigHost, System.Object[] hostInitConfigurationParams) [0x0000d] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.ConfigurationManager.OpenExeConfigurationInternal (System.Configuration.ConfigurationUserLevel userLevel, System.Reflection.Assembly calling_assembly, System.String exePath) [0x000ef] in <6c28c231fb4649d8b35542d065f04d1a>:0 
  at System.Configuration.ClientConfigurationSystem.get_Configuration () [0x0000e] in <6c28c231fb4649d8b35542d065f04d1a>:0 
   --- End of inner exception stack [...]
```
