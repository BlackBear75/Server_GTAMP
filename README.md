# Server_GTAMP  GTA V RageMP Server (Test Task)
1. Завантаж офіційний RageMP
Перейди на офіційний сайт:
👉 https://rage.mp/
та завантаж RAGE Multiplayer server package.

2. Розпакуй RageMP Server
Розпакуй у зручну папку
3. Додай цей проект у server-files
Якщо ти вже клонував репозиторій — просто заміни server-files або клонуй одразу:
git clone https://github.com/BlackBear75/Server_GTAMP.git server-files

4. Запуск сервера
ragemp-server.exe

5. Підключення до сервера
У RageMP Client:
Обери Direct Connect
Введи:
127.0.0.1:22005
   
Реалізований функціонал:
-Обробка підключення гравця (OnPlayerReady)
-Обробка відключення гравця (OnPlayerQuit)
-Призначення дефолтної точки спавну
-Відображення повідомлення при вході

Команди:
/pos	Виводить позицію гравця
/veh [model]	Спавнить транспорт
/money	Показує баланс гравця
/give [player] [amount]	Передає гроші іншому гравцеві

Клієнт–серверна взаємодія:
Передача позиції з клієнта на сервер (OnPlayerCreateWaypoint)
Телепортація до точки з мапи
