// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    document.getElementById('claimForm').addEventListener('submit', function (event) {
        event.preventDefault();
    const lecturerName = document.getElementById('lecturerName').value;
    const claimAmount = document.getElementById('claimAmount').value;
    const claimDescription = document.getElementById('claimDescription').value;

    const claimTableBody = document.getElementById('claimTableBody');
    const newRow = document.createElement('tr');
    newRow.innerHTML = `
    <td class="border border-gray-300 p-3">1</td>
    <td class="border border-gray-300 p-3">${lecturerName}</td>
    <td class="border border-gray-300 p-3">${claimAmount}</td>
    <td class="border border-gray-300 p-3">Pending</td>
    `;
    claimTableBody.appendChild(newRow);

    // Reset form fields
    document.getElementById('claimForm').reset();
    });
function uploadDocument() {
    // Logic to upload the document and display the file name
    const fileInput = document.getElementById('supportingDocument');
    if (fileInput.files.length > 0) {
        document.getElementById('uploadedFileName').innerText = fileInput.files[0].name;
    }
}
