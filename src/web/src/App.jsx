// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
// import './App.css'

// function App() {
//   const [count, setCount] = useState(0)

//   return (
//     <>
//       <div>
//         <a href="https://vite.dev" target="_blank">
//           <img src={viteLogo} className="logo" alt="Vite logo" />
//         </a>
//         <a href="https://react.dev" target="_blank">
//           <img src={reactLogo} className="logo react" alt="React logo" />
//         </a>
//       </div>
//       <h1>Vite + React</h1>
//       <div className="card">
//         <button onClick={() => setCount((count) => count + 1)}>
//           count is {count}
//         </button>
//         <p>
//           Edit <code>src/App.jsx</code> and save to test HMR
//         </p>
//       </div>
//       <p className="read-the-docs">
//         Click on the Vite and React logos to learn more
//       </p>
//     </>
//   )
// }

// export default App
import { useState } from "react";
import { getDpp, postCo2 } from "./api/dppApi";

export default function App(){
  const [id, setId] = useState("");
  const [dpp, setDpp] = useState(null);
  const [co2, setCo2] = useState("");

  const load = async () => { try { setDpp(await getDpp(id)); } catch(e){ alert(e.message);} };
  const update = async () => { try { setDpp(await postCo2(id, parseFloat(co2))); } catch(e){ alert(e.message);} };

  return (
    <main style={{padding:16,fontFamily:'system-ui'}}>
      <h1>OnePan · DPP</h1>
      <input placeholder="Produkt-ID" value={id} onChange={e=>setId(e.target.value)}/>
      <button onClick={load}>Hämta DPP</button>

      {dpp && (<div>
        <pre>{JSON.stringify(dpp, null, 2)}</pre>
        <input placeholder="Nytt CO₂" value={co2} onChange={e=>setCo2(e.target.value)}/>
        <button onClick={update}>Uppdatera CO₂</button>
      </div>)}
    </main>
  );
}
