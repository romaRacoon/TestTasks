# Репозиторий для тестовых заданий Rep for test tasks
## Навигация Navigation:
### СтэмБай(21.01.22) StamBuy(21.01.22)
#### ТЗ Terms of reference
>> Игрока представляет свинья. Передвижение игрока по уровню. Установка бомбы. Любого противника с несложным поведением(например,случайное передвижение по уровню). Взаимодействие бомбы с противником и главным персонажем - свиньей. Возможность управления с мобильного телефона (смартфона). Дополнительный функционал на ваше усмотрение,мы всегда за новые идеи
>>-------
>> The player is represented by a pig. Movement of the player through the level. Placing a bomb. Any opponent with uncomplicated behavior (e.g. random movement around the level). Interaction of the bomb with the enemy and the main character, the pig. Ability to control from a cell phone (smartphone). Additional functionality at your discretion, we are always for new ideas
#### [Реализация ТЗ Implementation of the terms of reference](https://github.com/romaRacoon/TestTasks/tree/stambuy)

-----------------------------------------
### Allemo(09.02.22) 
#### ТЗ Terms of reference
>> Краткое описание игры A brief description of the game
>>> Игра представляет из себя головоломку, где игроку нужно перемещать персонажа по лабиринту, с целью добраться до обозначенной точки.
>>> The game is a puzzle game where the player has to move the character through a maze in order to get to a designated point.

>> Механика перемещения объекта The mechanics of moving an object
>>> Персонаж появляется в нижней части лабиринта
>>> Руки игрового прикреплены к "шайбам" с рукоятками. Шайбы перемещаются в пределах ограниченной области тоннелей лабиринта.
>>> Шайбы перемещаются по одной.Объект повторяет движение за шайбой, управляемой игроком. 
>>> Для перемещения шайбы, игрок должен коснуться её пальцем, и не отпуская пальца, вести её в пределах тоннеля.
>>> На шайбу действует гравитация. Если игрок управляя шайбой, отпускает палец - шайба падает вниз.
>>> Если игрок удалит одну шайбу от другой на расстояние превышающее длину растяжения объекта - объект сорвется с шайбы и упадёт вниз. 
>>> Чем ближе шайбы к позициям максимального натяжения, тем большее сопротивление движению они должны оказывать. Это необходимо для передачи усилия от игрового персонажа к игроку.
>>> Конечными позициями, в которых должны оказаться шайбы, должны иметь соответствующие отметки. При достижении конечных позиций, игроку засчитывается победа.

>>>The character appears at the bottom of the maze The player's hands are attached to "pucks" with handles. The pucks move within a limited area of the maze tunnels. The pucks move one at a time.The object repeats the movement behind the puck, controlled by the player. To move the puck, the player must touch it with his finger, and without releasing his finger, lead it within the tunnel. The puck is affected by gravity. If the player controls the puck and lets go of his finger - the puck falls down. If the player removes one puck from the other at a distance greater than the length of the stretching of the object - the object will tear from the puck and fall down. The closer the pucks are to the positions of maximum tension, the more resistance to movement they should have. This is necessary to transfer the force from the game character to the player. The end positions in which the pucks should end up should have corresponding marks. When the end positions are reached, the player is scored a victory.

>> Поведение игрового персонажа Game Character Behavior
>>> Модель игрового персонажа должна иметь Ragdoll. Персонаж должен быть пластичным и "живым".
Игровой персонаж должен поворачивать голову и смотреть на ту шайбу с которой контактирует игрок.

>>> The model of the game character must have a Ragdoll. The character must be plastic and "alive". The game character must turn his head and look at the puck with which the player is in contact.

>> Игровая валюта Game currency
>>> В процессе прохождения уровня, игрок может собирать монеты. Кол-во собранных монет должно отображаться на экране.
Для того чтобы собрать монету, игровой персонаж должен коснуться её.
Монеты могут располагаться в любой части лабиринта.
Игрок может потратить эти монеты на улучшение.

>>> In the process of passing the level, the player can collect coins. The number of coins collected should be displayed on the screen.
In order to collect a coin, the game character must touch it.
Coins can be located in any part of the maze.
The player can spend these coins to improve.

>> Интерфейс Interface
>>> Стартовый экран с кнопкой Play, позволяющий начать прохождение уровня.
Окно с надписью Fail и кнопкой Restart, позволяющей перезапустить уровень.
Экран победы с надписью Completed и кнопкой Continue. 
Кол-во монет накопленных игроком, отображается в правой верхней части экрана.
Кнопка на начальном экране, позволяющая тратить накопленные монеты. Каждое нажатие увеличивает стоимость следующего на 1.
Надпись с номером уровня в верхней части экрана, при победе номер уровня должен меняться.

>>> The start screen with the Play button to start the level. The Fail screen with the Restart button to restart the level. Victory screen with Completed and Continue button. The amount of coins accumulated by the player, is displayed at the top right of the screen. Button on the start screen, allowing you to spend the accumulated coins. Each press increases the cost of the next by 1. The inscription with the level number at the top of the screen, when you win, the level number should change.

#### [Реализация ТЗ Implementation of the terms of reference](https://github.com/romaRacoon/TestTasks/tree/allemo)
