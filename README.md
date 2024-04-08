[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/UO7VGONk)
# Патерн абстрактна фабрика

Потрібно вивчити теоретичний матеріал та написати власноруч приклад коду для патерну абстрактна фабрика.
Закомітити даних приклад та зробити pull request.
Згідно власного варіанту потрібно описати потрібні класи. Додати до даних класів потрібні, на вашу думку, методи. Варіанти завдань отримати у викладача.
Закомітити код та зробити pull request.

В README файлі навести UML діаграму коду згідно власного варіанту з короткими поясненнями.

![image](https://github.com/Ostroh-Academy/05-abstract-factory-OleksiiKIiain/assets/85789953/209f650c-2c70-4267-bbfc-f9ffc48a598b)
![image](https://github.com/Ostroh-Academy/05-abstract-factory-OleksiiKIiain/assets/85789953/387a8b44-043f-4c32-9b0b-51c87a5d3566)
Ця діаграма представляє структуру системи віртуальних асистентів та їх фабрик.

IVirtualAssistant: Інтерфейс, який визначає методи SayHi() та SayBye(), які описують вітання та прощання віртуального асистента відповідно.

EnglishVirualAssistant, FrenchVirtualAssistant, SpanishVirtualAssistant: Конкретні реалізації віртуальних асистентів для англійської, французької та іспанської мов.

AssistantFactory: Абстрактна фабрика, яка визначає метод CreateAssistant(), щоб створювати екземпляри віртуальних асистентів.

EnglishAssistantFactory, FrenchAssistantFactory, SpanishAssistantFactory: Конкретні реалізації фабрик для створення віртуальних асистентів англійською, французькою та іспанською мовами.

Усі віртуальні асистенти наслідують методи SayHi() та SayBye() від інтерфейсу IVirtualAssistant. Кожна фабрика наслідує від AssistantFactory і реалізує метод CreateAssistant(), щоб створювати відповідних віртуальних асистентів.
