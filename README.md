# SignalRServiceExample
Test to see whether Azure SignalR Service supports multiplexing by default


Here is [Azure SignalR Service](https://azure.microsoft.com/en-us/products/signalr-service). It simplifies the process of adding real-time web functionality to applications over HTTP.


Here is my test process:

![image](https://github.com/martibook/SignalRServiceExample/assets/20094820/b22f981c-8bd3-4c9e-a087-96216305c0f2)


I have two clients AAA(left-hand side) and BBB(up-right) connected simultaneously. 

I also have a output window of web app server opened. 

When AAA sends out a big message (2MB), by clicking “Send” button, which makes the web app server outputs a line “Send – First letter of the message [L]”. 

Immediately after AAA sends out the message, it echoes a small message by clicking “Echo” button, which leads to server outputs a line “Echo – First letter of the message [0]”. 

**This means that when a client has only one connection, every message outgoing from it would be sent out one by one, synchronously. 
**

 ![image](https://github.com/martibook/SignalRServiceExample/assets/20094820/40deca9e-f08d-4599-bd2f-aa00eff95f5a)
