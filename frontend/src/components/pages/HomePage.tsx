import { useUserContext } from "../../context/UserContext";

function HomePage() {
  const { token } = useUserContext();

  return (
    <div>
      <h1>Bonjour Home</h1>
    </div>
  );
}

export { HomePage };
