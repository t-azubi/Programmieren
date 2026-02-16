const counterText = document.getElementById("counter-text");
const incrementButton = document.getElementById("increment");
const resetButton = document.getElementById("reset");

let counter = 0;

function render() {
  counterText.textContent = `Counter: ${counter}`;
}

incrementButton.addEventListener("click", () => {
  counter += 1;
  render();
});

resetButton.addEventListener("click", () => {
  counter = 0;
  render();
});
