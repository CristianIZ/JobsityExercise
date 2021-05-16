import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';
import { ChatViewModel } from '../models/chatviewmodel.model';


@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  public data: ChatViewModel[];

  private hubConnection: signalR.HubConnection;

  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:44388/chat')
      .build();

    this.hubConnection
      .start()
      .then(() => { console.log('Connection started') })
      .catch((err) => { console.log('Error while starting connection: ' + err) })
  }

  public addTransferChatDataListener = () => {
    this.hubConnection.on('transferChatData', (data) => {
      this.data = data;
      console.log(data);
    })
  }
}
