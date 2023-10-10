using Chapter6.HomeAutomation;
using Chapter6.HomeAutomation.CeilingFans;
using Chapter6.HomeAutomation.Lights;
using Chapter6.HomeAutomation.Stereos;

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

var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
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
remoteControl.OnButtonWasPushed(1);
remoteControl.OffButtonWasPushed(1);
remoteControl.OnButtonWasPushed(2);
remoteControl.OffButtonWasPushed(2);
remoteControl.OnButtonWasPushed(3);
remoteControl.OffButtonWasPushed(3);