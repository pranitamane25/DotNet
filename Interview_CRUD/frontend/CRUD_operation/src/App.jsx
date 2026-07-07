import React, { useEffect, useState } from "react";

function App() {
  const [tasks, setTasks] = useState([]);

  // 🔹 Load data from API
  useEffect(() => {
    fetch("http://localhost:5126/Task/GetAll")
      .then((res) => res.json())
      .then((data) => {
        console.log(data); 
        setTasks(data);
      })
      .catch((err) => console.error(err));
  }, []);

  return (
    <div style={{ padding: "20px" }}>
      <h2>Task List</h2>

      <table border="1" cellPadding="10">
        <thead>
          <tr>
            <th>ID</th>
            <th>Title</th>
            <th>Description</th>
            <th>Status</th>
          </tr>
        </thead>

        <tbody>
          {tasks.length > 0 ? (
            tasks.map((t) => (
              <tr key={t.taskId}>
                <td>{t.taskId}</td>
                <td>{t.title}</td>
                <td>{t.description}</td>
                <td>{t.status}</td>
              </tr>
            ))
          ) : (
            <tr>
              <td colSpan="4">No Data Found</td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
}

export default App;