//init
var NOTIFICATION_HOST = "https://localhost:44301/queueHub";
//var NOTIFICATION_HOST = "https://proddomain/queueHub";

var notificationSizeElement = document.getElementById("notification-size");
var notificationAudio = new Audio("/assets/media/ding.mp3");
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
    QueuePlayer(userDTO);
});

connection.on("UserDeQueued", (playerId) => {
    UserDeQueued(playerId);
});