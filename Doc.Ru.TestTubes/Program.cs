/*Одна лаборатория ищет лекарство от смертельной болезни. 
На испытание пришла партия из 1 000 пробирок с лекарством, 
которое нужно опробовать на людях. Стало известно, 
что среди пробирок одна является ядовитой. 
Внешне она ничем не отличается от медикамента. 
Необходимо как можно скорее отправить лекарство в больницы, 
но отправлять отравленную пробирку нельзя: погибнут люди. 
Испытание всех пробирок займут месяцы, это очень долго. 
Но в лаборатории есть лабораторные мыши. Известно, 
что лекарство безвредно для них, а даже капля яда их убьёт за сутки. 
Но в лаборатории только 10 мышей, а пробирок – 1 000. 
За какое время можно гарантированно найти пробирку с ядом?
*/

const uint START_NUMBER_TEST_TUBES = 1000;
const uint START_NUMBER_RATES = 10;
const uint DAYS_FOR_RATE_DIED = 1;
const float STOP_LOOP_WHEN_ONE_TUBE_ON_ONE_RATE = 1.0f;
const uint NUMBER_OF_POISON_TUBES = 1;

float tubesPerRate = 0f;                         //количество пробирок на одну крысу
uint countDay = 0;                               //счетчик дней
uint countLiveRates = START_NUMBER_RATES;        //счетчик живых крыс

do
{
    //в начале эксперимента каждой крысе дают лекарства из нескольких пробирок
    tubesPerRate = countDay == 0 ? START_NUMBER_TEST_TUBES / START_NUMBER_RATES : tubesPerRate / countLiveRates;
    countLiveRates -= NUMBER_OF_POISON_TUBES;
    if (countLiveRates < 1) throw (new ArgumentException("Task conditions are incorrect. There are too many poisoned test tubes and too few rats."));
    countDay += DAYS_FOR_RATE_DIED;
} while (tubesPerRate > STOP_LOOP_WHEN_ONE_TUBE_ON_ONE_RATE);

//в расчетах получается, что на 

Console.WriteLine($"Гарантировано найти пробирку можно за {countDay}");
Console.ReadLine();
