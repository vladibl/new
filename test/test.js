import { Selector } from 'testcafe';
    
fixture `Example page`
        .page `https://todomvc.com/examples/typescript-backbone/`;
//ввели запрос
        test('Emulate user actions and perform a verification', async t => {
        const inputNewTodo = ('body > section > header > div > input')
        await t.typeText(inputNewTodo,'Peter Parker\r\n')
//отметили галочкой все запросы
        const addedTodoElement =('body > section > section > label') 
        await t.click (addedTodoElement)
       
//убрали галочку с отмеченного запросы
       const addedTodoCheckboxAC =('body > section > section > ul > li > div > input')
        await t.click(addedTodoCheckboxAC)
//двойеное нажатие на запрос
       const addedTodoEditInput=('body > section > section > ul > li:nth-child(1) > div > label')
       await t.click(addedTodoEditInput)

      //удаляем запрос
      const addedTodoDelBtn = (
        'button.destroy')
        await t.click(addedTodoDelBtn);
        (elm) => (elm.previousSibling.innerText === 'New TODO element changed')
        
         
});
