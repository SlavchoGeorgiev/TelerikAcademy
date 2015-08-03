function solve() {
    return function (selector) {
        var $selectedElement = $(selector),
            $optionContainer,
            $currentValue,
            i, len, $currentOption;

        $('<div />')
            .addClass('dropdown-list')
            .insertBefore($selectedElement)
            .append($selectedElement
                .css('display', 'none'))
            .append($('<div />')
                .addClass('current')
                .attr('data-value', '')
                .text($selectedElement
                    .children()
                    .first()
                    .text()))
            .append($('<div />')
                .addClass('options-container')
                .css({
                    'position': 'absolute',
                    'display': 'none'
                }));


        $optionContainer = $('.options-container');
        len = $selectedElement.children().size();
        for (i = 0; i < len; i += 1) {
            $currentOption = $selectedElement
                .children()
                .eq(i);
            $optionContainer
                .append($('<div />')
                    .addClass('dropdown-item')
                    .attr('data-value', $currentOption.attr('value'))
                    .attr('data-index', i)
                    .text($currentOption.text()));
        }

        $currentValue = $('.current');
        $currentValue.on('click', function () {
            var $this = $(this);

            $this.text('Select a value');
            if ($optionContainer.css('display') == 'none') {
                $optionContainer.show();
            } else {
                $optionContainer.hide();
            }
        });

        $optionContainer.on('click', '.dropdown-item', function () {
            var $this = $(this);
            $currentValue
                .text($this.text());
            $(selector).val($this.attr('data-value'));
            $optionContainer.hide();
        });
    };
}

module.exports = solve;