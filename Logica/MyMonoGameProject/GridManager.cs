
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GridManager {
    private Texture2D _cellTexture;
    private Color[,] _grid;

    public GridManager(GraphicsDevice graphicsDevice) {
        _cellTexture = new Texture2D(graphicsDevice, 1,1);
        _cellTexture.SetData(new[] {Color.White});
        _grid = new Color[Global.WorldRows, Global.WorldCols];
        for (int y = 0; y < Global.WorldRows; y++) {
            for (int x = 0; x < Global.WorldCols; x++){
                _grid[y,x] = Color.Gray;
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch) {
        for (int y = 0; y < Global.WorldRows; y++) {
            for (int x = 0; x < Global.WorldCols; x++){
                var position = new Vector2(x * Global.CellSize, y * Global.CellSize);
                var color = _grid[y,x];
                spriteBatch.Draw(_cellTexture, position, null, color, 0f, Vector2.Zero, new Vector2(Global.CellSize, Global.CellSize), SpriteEffects.None, 0f);
            }
        }

        for (int y = 0; y <= Global.WorldRows; y++) {
            spriteBatch.Draw(_cellTexture, new Rectangle(0, y * Global.CellSize, Global.WorldCols * Global.CellSize, 1), Color.Black);
        }
        for (int x = 0; x <= Global.WorldCols; x++) {
        spriteBatch.Draw(_cellTexture, new Rectangle(x * Global.CellSize, 0, 1, Global.WorldRows * Global.CellSize), Color.Black);
        }
    }
}