# Chatroom API

## Overview
This project provides a backend API for a real-time chat application using ASP.NET Core, Entity Framework Core, and SignalR. It supports features such as user authentication, real-time messaging, friendship management, and private chats.

## Features
- **User Authentication:** Securely register, login, and logout users.
- **Real-Time Messaging:** Utilize SignalR to facilitate real-time communication.
- **Friendship Management:** Send, accept, or reject friend requests.
- **Private Chat:** Enable private messaging between friends.
- **Group Chat:** Create and manage group chats with multiple users.

## Technologies Used
- ASP.NET Core 8.0
- Entity Framework Core
- SignalR
- SQL Server


### API Endpoints
- **Auth**
- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login a user
- `POST /api/auth/logout` - Logout a user

- **Messages**
- `POST /api/messages` - Send a message

- **Friendships**
- `POST /api/friendships/sendrequest` - Send a friend request
- `POST /api/friendships/acceptrequest/{requestId}` - Accept a friend request
