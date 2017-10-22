let connection = new signalR.HubConnection('/chat');

$(function () {
    connection.on('send', data => {
        $('#messages').append($('<li align="left" style="background-color: #9acfea">').text(data));
    });
    
    $('#ChatForm').submit(function(){
        $('#messages').append($('<li align="right">').text($('#m').val()));
        connection.invoke('send', $('#m').val());
        $('#m').val('');
        return false;
    });
});

connection.start();
