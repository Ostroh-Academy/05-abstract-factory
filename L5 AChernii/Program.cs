namespace L5_A.Chernii_EC_4
{
    abstract class Character
    {
        public string CharacterType { get; protected set; }

        public abstract void Interact();
    }

    abstract class Weapon
    {
        public string WeaponType { get; protected set; }

        public abstract void UseWeapon();
    }

    abstract class Level
    {
        public string LevelType { get; protected set; }

        public abstract void Render();
    }

    class ShooterCharacter : Character
    {
        public ShooterCharacter()
        {
            CharacterType = "Стрiлець";
        }

        public override void Interact()
        {
            Console.WriteLine("Гравець 'Стрiлець' створено");
        }
    }

    class ShooterWeapon : Weapon
    {
        public ShooterWeapon()
        {
            WeaponType = "Гвинтiвка";
        }

        public override void UseWeapon()
        {
            Console.WriteLine("Стрiлецька зброя вистрiлює снарядом.");
        }
    }

    class ShooterLevel : Level
    {
        public ShooterLevel()
        {
            LevelType = "Двобiй";
        }

        public override void Render()
        {
            Console.WriteLine("Рендеринг рiвня шутера");
        }
    }

    class StrategyCharacter : Character
    {
        public StrategyCharacter()
        {
            CharacterType = "Командир";
        }

        public override void Interact()
        {
            Console.WriteLine("Стратегiчний персонаж вiддає накази пiдлеглим.");
        }
    }

    class StrategyWeapon : Weapon
    {
        public StrategyWeapon()
        {
            WeaponType = "Артилерiя";
        }

        public override void UseWeapon()
        {
            Console.WriteLine("Стратегiчна зброя атакує ворожi позицiї");
        }
    }

    class StrategyLevel : Level
    {
        public StrategyLevel()
        {
            LevelType = "Завойовник";
        }

        public override void Render()
        {
            Console.WriteLine("Рендеринг рiвня стратегiї");
        }
    }

    class AdventureCharacter : Character
    {
        public AdventureCharacter()
        {
            CharacterType = "Шукач пригод";
        }

        public override void Interact()
        {
            Console.WriteLine("Пригодницький персонаж вирiшує головоломки та дослiджує свiт.");
        }
    }

    class AdventureWeapon : Weapon
    {
        public AdventureWeapon()
        {
            WeaponType = "Меч";
        }

        public override void UseWeapon()
        {
            Console.WriteLine("Пригодницька зброя використовується для бою та вирiшення головоломок");
        }
    }

    class AdventureLevel : Level
    {
        public AdventureLevel()
        {
            LevelType = "Пiдземелля";
        }

        public override void Render()
        {
            Console.WriteLine("Рендеринг пригодницького рiвню");
        }
    }


    abstract class GameFactory
    {
        public abstract Character CreateCharacter();
        public abstract Weapon CreateWeapon();
        public abstract Level CreateLevel();
    }


    class ShooterGameFactory : GameFactory
    {
        public override Character CreateCharacter()
        {
            return new ShooterCharacter();
        }

        public override Weapon CreateWeapon()
        {
            return new ShooterWeapon();
        }

        public override Level CreateLevel()
        {
            return new ShooterLevel();
        }
    }

    class StrategyGameFactory : GameFactory
    {
        public override Character CreateCharacter()
        {
            return new StrategyCharacter();
        }

        public override Weapon CreateWeapon()
        {
            return new StrategyWeapon();
        }

        public override Level CreateLevel()
        {
            return new StrategyLevel();
        }
    }

    class AdventureGameFactory : GameFactory
    {
        public override Character CreateCharacter()
        {
            return new AdventureCharacter();
        }

        public override Weapon CreateWeapon()
        {
            return new AdventureWeapon();
        }

        public override Level CreateLevel()
        {
            return new AdventureLevel();
        }
    }


    class Program
    {
        static void PlayGame()
        {
            bool continueCreating = true;

            while (continueCreating)
            {
                Console.WriteLine("Виберiть жанр гри:");
                Console.WriteLine("1. Шутер");
                Console.WriteLine("2. Стратегiя");
                Console.WriteLine("3. Пригоди");
                Console.Write("Введiть номер: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    GameFactory gameFactory;

                    switch (choice)
                    {
                        case 1:
                            gameFactory = new ShooterGameFactory();
                            break;
                        case 2:
                            gameFactory = new StrategyGameFactory();
                            break;
                        case 3:
                            gameFactory = new AdventureGameFactory();
                            break;
                        default:
                            Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                            continue;
                    }

                    Character character = gameFactory.CreateCharacter();
                    Weapon weapon = gameFactory.CreateWeapon();
                    Level level = gameFactory.CreateLevel();

                    character.Interact();
                    weapon.UseWeapon();
                    level.Render();

                    Console.Write("Бажаєте продовжити створювання? (т/н): ");
                    continueCreating = Console.ReadLine().ToLower() == "т";
                }
                else
                {
                    Console.WriteLine("Невiрний ввiд. Спробуйте ще раз.");
                }
            }
        }

        static void Main(string[] args)
        {
            PlayGame();
        }
    }
}