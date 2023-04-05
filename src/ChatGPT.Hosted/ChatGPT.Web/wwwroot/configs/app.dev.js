module.exports = {
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/aspect-ratio')
    ],
    content: [
        "./Areas/**/*.cshtml",
        "./Pages/**/*.razor",
        "./Pages/**/*.cshtml",
        "./Pages/*.cshtml",
        "./Shared/**/*.razor",
        "./Shared/**/*.cshtml",
    ],
    theme: {
        extend: {},
        aspectRatio: {
            phone: '4 / 3'
        }
    },
}