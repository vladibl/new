import { Selector, t } from 'testcafe';

fixture(`Тестирование Todo list`)
    .page('https://todomvc.com/examples/typescript-backbone/');


test('Добавление задачи "Проверить MR 42"', async t => {
    const inputNewTodoNumberOne = ('div > input ')
    await t.typeText(inputNewTodoNumberOne,'Peter Parker\r\n')

});

test('Добавление задачи "Проверить возможность добавления очень длинного имени, которое не должно поместиться в одну строку"', async t => {
    
    const inputNewTodoNumberTwo = ('div > input ')
    await t.typeText(inputNewTodoNumberTwo,'Peter ParkerPeter ParkerPeter ParkerPeter Parker\r\n')


});

test('Проверить отметку выполненной одной задачи', async t => {
    const inputNewTodoNumberOne = ('div > input ')
    await t.typeText(inputNewTodoNumberOne,'Peter Parker\r\n')
    const addedTodoElement = ('li input ')
    await t.click (addedTodoElement)
});


test('Добавить 3 задачи и отметить их выполненными все разом (одним кликом)', async t => {
    const inputNewTodoNumberThree = ('div > input ')
    await t.typeText(inputNewTodoNumberThree,'Peter Parker\r\n')
    await t.typeText(inputNewTodoNumberThree,'Harry Potter\r\n')
    await t.typeText(inputNewTodoNumberThree,'Draco Malfoy\r\n')
    const addedTodoWin = ('body > section > section > label')
    await t.click (addedTodoWin)


});

test('Добавить 3 одинаковых задачи и удалить вторую' , async t => {
    const inputNewTodo = ('body > section > header > div > input')
    await t.typeText(inputNewTodo,'Peter Parker\r\n')
    await t.typeText(inputNewTodo,'Peter Parker\r\n')
    await t.typeText(inputNewTodo,'Peter Parker\r\n')

  
//Отмечаем задачу галочкой "выполненно" и удаляем задачу
const addedTodoDelBtn1 = ('body > section > section > ul > li:nth-child(2) > div > input')
await t.click(addedTodoDelBtn1)
const addedTodoDelBt2 = ('body > section > section > ul > li:nth-child(2) > div > button')
await t.click(addedTodoDelBt2)


});
    
test('Добавить 3 задачи и по очереди удалить', async t => {
    const inputNewTodo = ('body > section > header > div > input')
    await t.typeText(inputNewTodo,'Peter Parker\r\n')
    await t.typeText(inputNewTodo,'Harry Potter\r\n')
    await t.typeText(inputNewTodo,'Draco Malfoy\r\n')

 
    
//Отмечаем задачу галочкой "выполненно" и удаляем задачу
const addedTodoDelBtn1 = ('body > section > section > ul > li:nth-child(1) > div > input')
await t.click(addedTodoDelBtn1)
const addedTodoDelBt2 = ('body > section > section > ul > li.completed > div > button')
await t.click(addedTodoDelBt2)
const addedTodoDelBtn3 = ('body > section > section > ul > li:nth-child(1) > div > input')
await t.click(addedTodoDelBtn3)
const addedTodoDelBt4 = ('body > section > section > ul > li:nth-child(1) > div > button')
await t.click(addedTodoDelBt4)
const addedTodoDelBtn5 = ('body > section > section > ul > li > div > input')
await t.click(addedTodoDelBtn5)
const addedTodoDelBt6 = ('body > section > section > ul > li > div > button')
await t.click(addedTodoDelBt6)
});


