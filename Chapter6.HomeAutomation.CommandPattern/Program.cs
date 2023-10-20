using Chapter6.HomeAutomation.CommandPattern;
using Chapter6.HomeAutomation.CommandPattern.CeilingFans;
using Chapter6.HomeAutomation.CommandPattern.Lights;
using Chapter6.HomeAutomation.CommandPattern.Macros;
using Chapter6.HomeAutomation.CommandPattern.Stereos;

// Program.cs Is the Client


// Remote is the invoker, it will be passes a command object that can be used to make requests
var remote = new SimpleRemoteControl();
// Receiver of the request
var light = new Light("Living Room");
// Create command and pass the Receiver to it
var lightOn = new LightOnCommand(light);

// pass the command to the invoker
remote.SetCommand(lightOn);

remote.ButtonWasPressed();

// better remote

var remoteControl = new RemoteControl();

var livingRoomLight = new Light("Living Room");
var kitchenLight = new Light("Kitchen");
var ceilingFan = new CeilingFan("Living Room");
var stereo = new Stereo("Bed Room");

var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);

var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
var kitchenLightLightOffCommand = new LightOffCommand(kitchenLight); 

var ceilingFanHighCommand = new CeilingFanOnHighCommand(ceilingFan);
var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

var stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
var stereoOffCommand = new StereoOffCommand(stereo);

remoteControl.SetCommand(0,livingRoomLightOnCommand, livingRoomLightOffCommand);
remoteControl.SetCommand(1,kitchenLightOnCommand,kitchenLightLightOffCommand);
remoteControl.SetCommand(2,ceilingFanHighCommand,ceilingFanOffCommand);
remoteControl.SetCommand(3,stereoOnWithCDCommand,stereoOffCommand);


Console.WriteLine(remoteControl.ToString());

remoteControl.OnButtonWasPushed(0);
remoteControl.OffButtonWasPushed(0);
Console.WriteLine(remoteControl.ToString());
remoteControl.UndoButtonWasPushed();
remoteControl.OnButtonWasPushed(1);
remoteControl.OffButtonWasPushed(1);
remoteControl.OnButtonWasPushed(2);
remoteControl.OffButtonWasPushed(2);
remoteControl.OnButtonWasPushed(3);
Console.WriteLine(remoteControl.ToString());
remoteControl.OffButtonWasPushed(3);
remoteControl.UndoButtonWasPushed();


// Macros
var partyOn = new ICommand[]{livingRoomLightOnCommand, stereoOnWithCDCommand,ceilingFanHighCommand,kitchenLightOnCommand};
var partyOff = new ICommand[]{livingRoomLightOffCommand,stereoOffCommand,ceilingFanOffCommand,kitchenLightLightOffCommand};

var partyOnMacro = new MacroCommand(partyOn);


var partyOffMacro = new MacroCommand(partyOff);
remoteControl.SetCommand(6,partyOnMacro,partyOffMacro);

Console.WriteLine(remoteControl.ToString());
Console.WriteLine("Pushing On Macro");
remoteControl.OnButtonWasPushed(6);
Console.WriteLine("Pushing Off Macro");
remoteControl.OffButtonWasPushed(6);

Console.WriteLine("Undo Macro");
remoteControl.UndoButtonWasPushed();