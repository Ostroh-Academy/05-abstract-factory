[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/UO7VGONk)
# Патерн абстрактна фабрика

Потрібно вивчити теоретичний матеріал та написати власноруч приклад коду для патерну абстрактна фабрика.
Закомітити даних приклад та зробити pull request.
Згідно власного варіанту потрібно описати потрібні класи. Додати до даних класів потрібні, на вашу думку, методи. Варіанти завдань отримати у викладача.

В README файлі навести UML діаграму класів для коду згідно власного варіанту з короткими поясненнями.
Закомітити код та зробити pull request.


![L5 Game](https://github.com/Ostroh-Academy/05-abstract-factory-AChernii/assets/103105210/aca07b37-1588-4dd3-bcc4-e7c0fea9db6d)

Character - абстрактний клас, що визначає інтерфейс для персонажів гри. Містить поле CharacterType та абстрактний метод Interact().

ShooterCharacter, StrategyCharacter, AdventureCharacter - конкретні реалізації класу Character для різних жанрів ігор.

Weapon - абстрактний клас, що визначає інтерфейс для зброї. Містить поле WeaponType та абстрактний метод UseWeapon().

ShooterWeapon, StrategyWeapon, AdventureWeapon - конкретні реалізації класу Weapon для різних жанрів ігор.

Level - абстрактний клас, що визначає інтерфейс для рівнів гри. Містить поле LevelType та абстрактний метод Render().

ShooterLevel, StrategyLevel, AdventureLevel - конкретні реалізації класу Level для різних жанрів ігор.

GameFactory - абстрактний клас, що визначає інтерфейс для фабрики ігрових елементів. Містить абстрактні методи CreateCharacter(), CreateWeapon() та CreateLevel().

ShooterGameFactory, StrategyGameFactory, AdventureGameFactory - конкретні реалізації класу GameFactory для різних жанрів ігор.
