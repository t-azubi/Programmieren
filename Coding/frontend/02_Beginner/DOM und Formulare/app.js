const form = document.getElementById("task-form");
const taskInput = document.getElementById("task");
const message = document.getElementById("message");
const taskList = document.getElementById("task-list");

form.addEventListener("submit", (event) => {
  event.preventDefault();

  const value = taskInput.value.trim();
  if (value.length < 3) {
    message.textContent = "Bitte mindestens 3 Zeichen eingeben.";
    return;
  }

  const item = document.createElement("li");
  item.textContent = value;
  taskList.appendChild(item);

  message.textContent = "";
  form.reset();
  taskInput.focus();
});
