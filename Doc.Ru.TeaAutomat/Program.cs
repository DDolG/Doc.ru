﻿/*
    На кухне компании «Док.ру» поставили 3 автомата, 
    которые наливают напитки. В первом – зеленый чай, 
    во втором – черный, а третий выдаёт случайным образом то черный, 
    то зеленый чай. Но пара программистов решила подшутить 
    над коллегами и поменяла маркировку автоматов, поэтому на каждом 
    из них оказалась неправильная наклейка. Сколько попыток понадобится, 
    чтобы понять где какой напиток?
 */

/*
    Решение:
        1) Подходим к автомату с надписью "черный чай". Два раза подряд наливаем. 
        Если там два раза подряд был черный чай, значит маркировка верная. Если нет:
            а) два раза "зеленый чай", меняемся  маркеровками с "зеленым чаем";
            б) разные чаи, меняемся с маркировками с "черный / зеленый"
        2) Проверяем автомат с надписью "зеленый чай". Наливаем два раза подряд.
        Если два раза подряд оттуда вытекает зеленый чай, то маркеровка верна.
            а) разные чаи, меняемся с маркировками с "черный / зеленый"
 */