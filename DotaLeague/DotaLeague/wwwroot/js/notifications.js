//init
var NOTIFICATION_HOST = "https://localhost:44301/hubs/queueHub";
//var NOTIFICATION_HOST = "https://proddomain/hubs/queueHub";

var notificationSizeElement = document.getElementById("notification-size");
var notificationAudio = new Audio("/media/notif.mp3");
notificationAudio.load();

//SignalR
const connection = new signalR.HubConnectionBuilder()
    .withUrl(NOTIFICATION_HOST)
    .configureLogging(signalR.LogLevel.Information)
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 15000);
    }
};

connection.onclose(start);

// Start the connection.
start();

connection.on("UserQueued", (userDTO) => {
    OnUserQueued(userDTO);
});

//on message receive
function OnUserQueued(userDTO) {
    console.log(userDTO);
}