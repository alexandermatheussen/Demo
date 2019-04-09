$(document).ready(function() {
    var numberOfFields = 0;
    var numberOfOptions = 0;
    $('#btnAddField').click(function() {
        var questionType = 'textarea';
        numberOfFields++;
        
        $('<div></div>')
            .attr('id', 'dynamicDiv' + numberOfFields)
            .appendTo('#fields');
        $('<hr>').appendTo('#dynamicDiv' + numberOfFields);
        $('<h5>What do you want to ask?</h5>').appendTo('#dynamicDiv' + numberOfFields);
        $('<input type="text" name="question.question" />').appendTo('#dynamicDiv' + numberOfFields);
        $('<br>').appendTo('#dynamicDiv' + numberOfFields);
        $('<h5>What type of a question is this?</h5>').appendTo('#dynamicDiv' + numberOfFields);
        $('<fieldset></fieldset>')
            .attr('id', 'dynamicFieldset' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<input type="radio" checked />')
            .attr('id', 'dynamicTextArea' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'textarea')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<span> Text area</span>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicEmail' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'email')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<span> E-mail field</span>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicDropDown' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'dropdown')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<span> Dropdown menu</span>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicRadioButton' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'radiobutton')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<span> Radio buttons</span>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicCheckBox' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'checkbox')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<span> Check boxes</span>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<div></div>')
            .attr('id', 'addOptionPlaceholder' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<div></div>')
            .attr('id', 'optionPlaceholder' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<button type="button">Remove question</button>')
            .attr('id', 'btnRemoveField' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
                
        var currentField = numberOfFields;
        
        $('#btnRemoveField' + numberOfFields).click(function() {
            $('#dynamicDiv' + currentField).remove();
        });

        $('#dynamicCheckBox' + numberOfFields).change(function() { questionType = 'checkbox'; checkForOptions(); });
        $('#dynamicTextArea' + numberOfFields).change(function() { questionType = 'textarea'; checkForOptions(); });
        $('#dynamicDropDown' + numberOfFields).change(function() { questionType = 'dropdown'; checkForOptions(); });
        $('#dynamicRadioButton' + numberOfFields).change(function() { questionType = 'radiobutton'; checkForOptions(); });
        $('#dynamicEmail' + numberOfFields).change(function() { questionType = 'email'; checkForOptions(); });

        function checkForOptions() {
            var currentOption = numberOfOptions;
            
            $('#btnAddOption' + currentField).remove();
            if(questionType === 'checkbox' || questionType === 'dropdown' || questionType === 'radiobutton') {
                $('<button type="button">Add option</button>')
                    .attr('id', 'btnAddOption' + currentField)
                    .appendTo('#addOptionPlaceholder' + currentField);
            }
            
            $('#btnAddOption' + currentField).click(function() {
                currentOption++;
                
                $('<div></div>')
                    .attr('id', 'optionField' + currentOption + currentField)
                    .appendTo('#optionPlaceholder' + currentField);
                $('<input type="text" />')
                    .attr('id', 'inputOption' + currentOption + currentField)
                    .attr('name', 'question.options' + '-' + currentOption + '-' + currentField)
                    .appendTo('#optionField' + currentOption + currentField);
                $('<button type="button">Remove option</button>')
                    .attr('id', 'btnRemoveOption' + '-' + currentOption + '-' + currentField)
                    .appendTo('#optionField' + currentOption + currentField);
                
                $('#btnRemoveOption' + '-' + currentOption + '-' + currentField).click(function() {
                    var btnName = $(this).attr('id');
                    var array = btnName.split("-");
                    var thisCurrentOption = array[1];
                    var thisCurrentField = array[2];
                    $('#optionField' + thisCurrentOption + thisCurrentField).remove();
                });
            });
        }
    });
});