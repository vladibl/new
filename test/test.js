import { Selector } from 'testcafe';


fixture `Example page`
    .page `https://todomvc.com/examples/typescript-backbone/`;

    test('Emulate user actions and perform a verification', async t => {
        await t.setNativeDialogHandler(() => true);
        const inputNewTodo = await querySelector('new-todo');
        await t.typeText(inputNewTodo, 'New TODO element\r\n');
    
        const addedTodoElement = await querySelectorCondition(
            'section.main label',
            (elm) => (elm.innerText === 'New TODO element')
        );
    
        await t.doubleClick(addedTodoElement);
    
        const addedTodoEditInput = await querySelectorCondition(
            'section.main input[type=text]',
            (elm) => (elm.value === 'New TODO element')
        );
    
        await t.typeText(addedTodoEditInput, ' changed\r\n');
    
        const addedTodoCheckboxAC = await querySelectorCondition(
            'section.main input[type=checkbox]:not([checked])',
            (elm) => (elm.nextSibling.innerText === 'New TODO element changed')
        );
    
        await t.click(addedTodoCheckboxAC);
    
        const addedTodoCheckboxBC = await querySelectorCondition(
            'section.main input[type=checkbox]',
            (elm) => (elm.nextSibling.innerText === 'New TODO element changed')
        );
    
        await t.click(addedTodoCheckboxBC);
    
        const addedTodoDelBtn = await querySelectorCondition(
            'button.destroy',
            (elm) => (elm.previousSibling.innerText === 'New TODO element changed')
        );
    
        await t.click(addedTodoDelBtn);
    });