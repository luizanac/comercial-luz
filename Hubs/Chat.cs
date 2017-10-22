using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ContaLuz.Hubs
{
	public class Chat : Hub
	{
		public Task Send(string data)
		{
			return Clients.AllExcept(new List<string>
			{
				Context.ConnectionId
			}).InvokeAsync("send", $" {Context.ConnectionId} disse: {data}");
		}

		public override Task OnConnectedAsync()
		{
			base.OnConnectedAsync();
			return Clients.AllExcept(new List<string>
			{
				Context.ConnectionId
			}).InvokeAsync("send", $"{Context.ConnectionId} entrou no chat :)");
				
		}

		public override Task OnDisconnectedAsync(Exception exception)
		{
			base.OnConnectedAsync();
			return Clients.All.InvokeAsync("send", $"{Context.ConnectionId} saiu do chat :)");
		}
	}
}