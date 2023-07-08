*This is a sample project for study and future consultations.

## Server Sent Events

Server-Sent Events (SSE) is a web technology that enables servers to push data to clients over a single, long-lived HTTP connection. It provides a simple and efficient way to deliver real-time updates or notifications from the server to the client. SSE is based on a unidirectional communication model, where the server sends messages to the client without the need for the client to send data back.

With SSE, the client establishes an HTTP connection to the server and keeps it open. The server can then send messages as text/event-stream data, which the client receives as a stream of events. Each event can contain a specific type, an optional event identifier, and a data payload. The client can listen for these events and handle them as they arrive, allowing for real-time updates to be displayed to the user.

SSE has several advantages, including its simplicity, compatibility with existing web infrastructure, and automatic reconnection handling. It works well with modern browsers and doesn't require any additional protocols or libraries. SSE is particularly useful for applications that require one-way communication, such as real-time notifications, live updates, or event-driven systems.

## SSE vs. Websockets

When it comes to delivering real-time notifications to users, both Server-Sent Events (SSE) and WebSockets are viable options, but they have different characteristics and use cases. Let's compare them:

Server-Sent Events (SSE):

- SSE is a technology that allows a server to push data to a client over a single HTTP connection.
- SSE is well-suited for applications that require one-way communication, where the server sends updates to clients but clients don't need to send data back to the server in real-time.
- SSE uses a standard HTTP connection, making it easier to deploy on existing infrastructure and work with proxies and load balancers.
- SSE supports automatic reconnection, which means that if the connection is interrupted, the client will automatically attempt to reconnect to the server.
- SSE has a simple API and works well with modern browsers.

WebSockets:

- WebSockets provide full-duplex communication channels over a single TCP connection, allowing both the client and server to send data at any time.
- WebSockets are suitable for applications that require bidirectional communication, such as chat applications or collaborative tools.
- WebSockets have a lower latency compared to SSE because they maintain a persistent connection and can send data instantly without the overhead of establishing a new connection.
- WebSockets have a more complex API compared to SSE, as they involve opening a WebSocket connection and handling events for sending and receiving data.
- WebSockets require server-side support for handling WebSocket connections and managing the associated state.

In summary, if you only need one-way communication and automatic reconnection is important to you, SSE is a simpler option that works well with existing infrastructure. On the other hand, if you require bidirectional communication or need lower latency, WebSockets are a more suitable choice, although they require additional server-side support. Consider your specific requirements and choose the technology that aligns best with your needs.

## Running

To run the application, it's necessary to have the .NET 7 SDK. Just enter `dotnet run` in your terminal and check the URL the app is running.
Now, in your browser, put the URL with /index.html to access the sandbox.
