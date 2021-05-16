import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SignalRService } from 'src/app/services/signal-r.service';

@Component({
  selector: 'app-chat-component',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  constructor(public signalRService: SignalRService,
    private http: HttpClient) { }

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.addTransferChatDataListener();
    this.startHttpRequest();
  }

  private startHttpRequest = () => {
    this.http.get('https://localhost:44388/api/chat')
    .subscribe((res) => {
      console.log(res);
    })
  }
}
