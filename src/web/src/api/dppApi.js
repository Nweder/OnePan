export async function getDpp(id){
  const r = await fetch(`/api/dpp/${id}`);
  if(!r.ok) throw new Error('Hittar inte produkt');
  return r.json();
}
export async function postCo2(id, co2){
  const r = await fetch(`/api/dpp/${id}/co2`, {
    method:'POST', headers:{'Content-Type':'application/json'},
    body: JSON.stringify({ co2 })
  });
  if(!r.ok) throw new Error('Kunde inte uppdatera');
  return r.json();
}
