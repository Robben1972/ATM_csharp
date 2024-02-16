int Yesno()
{
    Console.WriteLine("Yana boshqa amalni bajarishni hohlaysizmi?");
    Console.WriteLine("1.Ha           2.Yo'q");
    int yesNo = int.Parse(Console.ReadLine()!);
    return yesNo;   
}
void space()
{
    Console.Clear();
    Console.WriteLine(".");
    Thread.Sleep(500);
    Console.Clear();
    Console.WriteLine("..");
    Thread.Sleep(500);
    Console.Clear();
    Console.WriteLine("...");
    Thread.Sleep(500);
    Console.Clear();
}
int card = 1000000;
int password = 1234;
int chance = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("1.Uzbek                  2.Russian                  3.English");
    Console.Write("Tilni tanlang: ");
    int variant = int.Parse(Console.ReadLine()!);
    space();
    switch (variant)
    {
        case 1:
            while (true) { 
                Console.Write("Kirish uchun parolni kiriting: ");
                int inputPassword = int.Parse(Console.ReadLine()!);
                space();
                if(inputPassword == password)
                {
                    chance = 0;
                    break;
                }else
                {
                    chance++;
                    if(chance == 3)
                    {
                        Console.WriteLine("Sizning kartangiz emas");
                        return;
                    }
                    Console.WriteLine("Xato! Qayta urinib ko'ring!");
                }
            }
            Console.WriteLine("1.Mablag'ni tekshirish");
            Console.WriteLine("2.Naqt pul olish");
            Console.WriteLine("3.Tulovlar qilish");
            Console.WriteLine("4.SMS habarni ulash");
            Console.WriteLine("5.Parolni o'zgartirish");
            Console.WriteLine("6.Chiqish");
            Console.Write("Bo'limni tanlang: ");
            int section = int.Parse(Console.ReadLine()!);
            space();
            switch (section)
            {
                case 1: Console.WriteLine("Sizning mablag'ingiz: " + card);
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 2: Console.Write("Qancha mablag' olmoqchiligingizni kiriting: ");
                    int cashSum = int.Parse(Console.ReadLine()!);
                    space();
                    if (cashSum < card)
                    {
                        card -= cashSum;
                        Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                    }
                    else
                    {
                        Console.WriteLine("Mablag' yetarli emas");
                    }
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Nimalar uchun tulov qilmoqchisiz?");
                    Console.WriteLine("1.Gaz");
                    Console.WriteLine("2.Svet");
                    Console.WriteLine("3.Suv");
                    Console.WriteLine("4.Telefon raqam");
                    Console.Write("To'lov uchun bo'limni tanlang: ");
                    int sectionForPay = int.Parse(Console.ReadLine()!);
                    space();
                    switch (sectionForPay)
                    {
                        case 1:
                            Console.Write("Gazga to'lov qilish uchun maxsus raqamni kiriting: ");
                            int gazNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Tulov uchun summani kiriting: ");
                            int sumGaz = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumGaz<card)
                            {
                                card -= sumGaz;
                                Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                            }
                            else
                            {
                                Console.WriteLine("Mablag' yetarli emas");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 2:
                            Console.Write("Svetga to'lov qilish uchun maxsus raqamni kiriting: ");
                            int svetNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Tulov uchun summani kiriting: ");
                            int sumSvet = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumSvet < card)
                            {
                                card -= sumSvet;
                                Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                            }
                            else
                            {
                                Console.WriteLine("Mablag' yetarli emas");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 3:
                            Console.Write("Suvga to'lov qilish uchun maxsus raqamni kiriting: ");
                            int waterNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Tulov uchun summani kiriting: ");
                            int sumWater = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumWater < card)
                            {
                                card -= sumWater;
                                Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                            }
                            else
                            {
                                Console.WriteLine("Mablag' yetarli emas");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 4:
                            Console.WriteLine("To'lov uchun kompaniyani tanlang");
                            Console.WriteLine("1.Beeline");
                            Console.WriteLine("2.Ucell");
                            int sectionCompany = int.Parse(Console.ReadLine()!);
                            space();
                            switch (sectionCompany)
                            {
                                case 1:
                                    Console.Write("+998 90 ");
                                    int beelineNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Summani kiriting: ");
                                    int beelineSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (beelineSum < card) { 
                                        card -= beelineSum;
                                        Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                                    }
                                    else {
                                        Console.WriteLine("Mablag' yetarli emas");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                                case 2:
                                    Console.Write("+998 93 ");
                                    int ucellNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Summani kiriting: ");
                                    int ucellSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (ucellSum < card)
                                    {
                                        card -= ucellSum;
                                        Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Mablag' yetarli emas");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    Console.Write("SMS xabarni ulamoqchi bo'lgan raqamingizni kiritign: +998 ");
                    int number = int.Parse(Console.ReadLine()!);
                    space();
                    Console.WriteLine("Muvafaqiyatli ulandi");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 5:
                    Console.Write("Yangi parolni kiriting: ");
                    int newPassword =   int.Parse(Console.ReadLine()!);
                    space();
                    password = newPassword;
                    Console.WriteLine("Muvofaqiyatli amalga oshirildi");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 6:
                    return;
            }
            break;
    case 2:

            while (true)
            {
                Console.Write("Введите пароль для входа: ");
                int inputPassword = int.Parse(Console.ReadLine()!);
                space();
                if (inputPassword == password)
                {
                    chance = 0;
                    break;
                }
                else
                {
                    chance++;
                    if (chance == 3)
                    {
                        Console.WriteLine("Ваша карта заблокирована");
                        return;
                    }
                    Console.WriteLine("Ошибка! Попробуйте снова!");
                }
            }

            Console.WriteLine("1. Проверить баланс");
            Console.WriteLine("2. Снять наличные");
            Console.WriteLine("3. Оплатить счета");
            Console.WriteLine("4. Отправить SMS");
            Console.WriteLine("5. Изменить пароль");
            Console.WriteLine("6. Выйти");
            Console.Write("Выберите опцию: ");
            int sectionRus = int.Parse(Console.ReadLine()!);
            space();
            switch (sectionRus)
            {
                case 1:
                    Console.WriteLine("Ваш баланс: " + card);
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 2:
                    Console.Write("Введите сумму для снятия: ");
                    int cashSum = int.Parse(Console.ReadLine()!);
                    space();
                    if (cashSum <= card)
                    {
                        card -= cashSum;
                        Console.WriteLine("Операция выполнена успешно");
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств на счете");
                    }
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Наличие счетов:");
                    Console.WriteLine("1. Газ");
                    Console.WriteLine("2. Свет");
                    Console.WriteLine("3. Вода");
                    Console.WriteLine("4. Телефонный номер");
                    Console.Write("Выберите раздел для оплаты: ");
                    int sectionForPay = int.Parse(Console.ReadLine()!);
                    space();
                    switch (sectionForPay)
                    {
                        case 1:
                            Console.Write("Введите номер для оплаты газа: ");
                            int gazNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Введите сумму оплаты: ");
                            int sumGaz = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumGaz <= card)
                            {
                                card -= sumGaz;
                                Console.WriteLine("Операция выполнена успешно");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств на счете");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 2:
                            Console.Write("Введите номер для оплаты света: ");
                            int svetNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Введите сумму оплаты: ");
                            int sumSvet = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumSvet <= card)
                            {
                                card -= sumSvet;
                                Console.WriteLine("Операция выполнена успешно");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств на счете");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 3:
                            Console.Write("Введите номер для оплаты воды: ");
                            int waterNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Введите сумму оплаты: ");
                            int sumWater = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumWater <= card)
                            {
                                card -= sumWater;
                                Console.WriteLine("Операция выполнена успешно");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств на счете");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Выберите компанию для оплаты");
                            Console.WriteLine("1. Билайн");
                            Console.WriteLine("2. Укелл");
                            int sectionCompany = int.Parse(Console.ReadLine()!);
                            space();
                            switch (sectionCompany)
                            {
                                case 1:
                                    Console.Write("+998 90 ");
                                    int beelineNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Введите сумму оплаты: ");
                                    int beelineSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (beelineSum <= card)
                                    {
                                        card -= beelineSum;
                                        Console.WriteLine("Операция выполнена успешно");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Недостаточно средств на счете");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                                case 2:
                                    Console.Write("+998 93 ");
                                    int ucellNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Введите сумму оплаты: ");
                                    int ucellSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (ucellSum <= card)
                                    {
                                        card -= ucellSum;
                                        Console.WriteLine("Операция выполнена успешно");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Недостаточно средств на счете");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    Console.Write("Введите номер для отправки SMS: +998 ");
                    int number = int.Parse(Console.ReadLine()!);
                    space();
                    Console.WriteLine("Сообщение успешно отправлено");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 5:
                    Console.Write("Введите новый пароль: ");
                    int newPassword = int.Parse(Console.ReadLine()!);
                    space();
                    password = newPassword;
                    Console.WriteLine("Пароль успешно изменен");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 6:
                    return;
            }
            break;
    case 3:
            while (true)
            {
                Console.Write("Enter the password to log in: ");
                int inputPassword = int.Parse(Console.ReadLine()!);
                space();
                if (inputPassword == password)
                {
                    chance = 0;
                    break;
                }
                else
                {
                    chance++;
                    if (chance == 3)
                    {
                        Console.WriteLine("Your card is blocked");
                        return;
                    }
                    Console.WriteLine("Error! Try again!");
                }
            }

            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw cash");
            Console.WriteLine("3. Pay bills");
            Console.WriteLine("4. Send SMS");
            Console.WriteLine("5. Change password");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int sectionEng = int.Parse(Console.ReadLine()!);
            space();
            switch (sectionEng)
            {
                case 1:
                    Console.WriteLine("Your balance: " + card);
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 2:
                    Console.Write("Enter the amount to withdraw: ");
                    int cashSum = int.Parse(Console.ReadLine()!);
                    space();
                    if (cashSum <= card)
                    {
                        card -= cashSum;
                        Console.WriteLine("Transaction successful");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds in your account");
                    }
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Bills available:");
                    Console.WriteLine("1. Gas");
                    Console.WriteLine("2. Electricity");
                    Console.WriteLine("3. Water");
                    Console.WriteLine("4. Phone number");
                    Console.Write("Choose a section to pay: ");
                    int sectionForPay = int.Parse(Console.ReadLine()!);
                    space();
                    switch (sectionForPay)
                    {
                        case 1:
                            Console.Write("Enter the gas account number: ");
                            int gazNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Enter the payment amount: ");
                            int sumGaz = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumGaz <= card)
                            {
                                card -= sumGaz;
                                Console.WriteLine("Transaction successful");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds in your account");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 2:
                            Console.Write("Enter the electricity account number: ");
                            int svetNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Enter the payment amount: ");
                            int sumSvet = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumSvet <= card)
                            {
                                card -= sumSvet;
                                Console.WriteLine("Transaction successful");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds in your account");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 3:
                            Console.Write("Enter the water account number: ");
                            int waterNumber = int.Parse(Console.ReadLine()!);
                            Console.Write("Enter the payment amount: ");
                            int sumWater = int.Parse(Console.ReadLine()!);
                            space();
                            if (sumWater <= card)
                            {
                                card -= sumWater;
                                Console.WriteLine("Transaction successful");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds in your account");
                            }
                            if (Yesno() != 1)
                            {
                                return;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Choose a company for payment");
                            Console.WriteLine("1. Beeline");
                            Console.WriteLine("2. Ucell");
                            int sectionCompany = int.Parse(Console.ReadLine()!);
                            space();
                            switch (sectionCompany)
                            {
                                case 1:
                                    Console.Write("+998 90 ");
                                    int beelineNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Enter the payment amount: ");
                                    int beelineSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (beelineSum <= card)
                                    {
                                        card -= beelineSum;
                                        Console.WriteLine("Transaction successful");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient funds in your account");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                                case 2:
                                    Console.Write("+998 93 ");
                                    int ucellNumber = int.Parse(Console.ReadLine()!);
                                    Console.Write("Enter the payment amount: ");
                                    int ucellSum = int.Parse(Console.ReadLine()!);
                                    space();
                                    if (ucellSum <= card)
                                    {
                                        card -= ucellSum;
                                        Console.WriteLine("Transaction successful");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient funds in your account");
                                    }
                                    if (Yesno() != 1)
                                    {
                                        return;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    Console.Write("Enter the number for SMS: +998 ");
                    int number = int.Parse(Console.ReadLine()!);
                    space();
                    Console.WriteLine("Message sent successfully");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 5:
                    Console.Write("Enter a new password: ");
                    int newPassword = int.Parse(Console.ReadLine()!);
                    space();
                    password = newPassword;
                    Console.WriteLine("Password changed successfully");
                    if (Yesno() != 1)
                    {
                        return;
                    }
                    break;
                case 6:
                    return;
            }

            break;
    }
}