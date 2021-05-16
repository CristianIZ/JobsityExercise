import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SignalRService } from 'src/app/services/signal-r.service';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-chat-component',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  public messageToSend: string;
  public chatForm: FormGroup;

  constructor(public signalRService: SignalRService,
    private http: HttpClient,
    private fb: FormBuilder) { }

  ngOnInit(): void {
    this.initForm();

    this.signalRService.startConnection();
    this.signalRService.addTransferChatDataListener();
    this.signalRService.addBroadcastChatDataListener();
    this.startHttpRequest();
  }

  private startHttpRequest = () => {
    this.http.get('https://localhost:44388/api/chat')
    .subscribe((res) => {
      console.log(res);
    })
  }

  public initForm(){
    this.chatForm = this.fb.group({
      chatText: [
        { value: '' },
        [Validators.required, Validators.maxLength(100)],
      ],
    });
  }

  public sendChatMessage(): void {
    debugger;
    this.signalRService.broadcastChatData();
  }
}
