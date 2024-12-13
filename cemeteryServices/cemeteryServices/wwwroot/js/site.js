// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById('view-services-btn').addEventListener('click', function(event) {
    event.preventDefault();
    document.getElementById('packages-section').scrollIntoView({ behavior: 'smooth' });
});
