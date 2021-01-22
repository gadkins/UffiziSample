import React, { useState, useEffect } from "react";

function App() {
  const [jokes, setJokes] = useState([]);

  useEffect(() => {
    fetch("/api/jokes")
      .then((res) => res.json())
      .then(setJokes);
  });

  return (
    <div className="App">
      {jokes.map((joke) => (
        <div
          key={joke.id}
          style={{
            padding: "20px",
            border: "2px solid tomato",
            margin: "20px",
          }}
        >
          <p>{joke.setup}</p>
          <p>{joke.punchline}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
