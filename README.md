# BadJujuWorkshopManager
Unturned RocketMod/LDM Plugin
<br>Данный плагин позволит вам:
<br>1) Изменить способ загрузки модов на сервер
<br>Теперь вам не нужно будет работать с JSON файлом, если вы хотите установить модификации на сервер, вы можете это делать прямо через конфигурацию плагина. Стандартный способ <br>загрузки не удобен тем, что в нем нельзя оставлять комментарии и, если у вас большое количество модификаций на сервере вы можете запутаться за что отвечает тот или иной мод, <br>если вы видите только его ID, плагин исправляет проблему - вы можете вставить описание для каждого мода(в поле Description), чтобы его можно было с легкостью заменить/удалить, <br>а не тратить время на поиски. Также каждый мод вы можете сделать загружаемым только в определенный день недели, для этого в поле time необходимо вписать этот самый день, к <br>примеру, для ежнедельных ивентов
<br>2) Менять карту сервера автоматически зависимо от дня недели
<br>К примеру, в понедельник у вас на сервере карта PEI, а в среду она изменяется на карту Russia автоматически при рестарте.
<br>Конфигурация
<br>Mod:
<br>Id - айди модификации, находится в конце ссылки на сам мод в стиме (https://steamcommunity.com/sharedfiles/filedetails/?i..)
<br>Description - ваше описание модификации
<br>time - день недели, когда мод будет загружаться. Если хотите сделать ежедневную загрузку, то поставьте в данном поле "Regular"
<br>Понедельник - "Monday"
<br>Вторник - "Tuesday"
<br>Среда - "Wednesday"
<br>Четверг - "Thursday"
<br>Пятница - "Friday"
<br>Суббота - "Saturday"
<br>Воскресенье - "Sunday"
<br>Map:
<br>Name - имя карты, учитывает регистр, поэтому, если название в оригинале начинается с заглавной буквы, то и в конфигурации пишите также
<br>time - аналогичен предыдущему разделу
