
	<form method="post" action="demande.php" id="form"class="formulaire">	
		<!--ZONE 1-->

			<fieldset class="coordonne">
			<legend><span class="degrade1">Contact</span></legend>
				<fieldset class="champ">
				<legend><span class="degrade1">Vos coordonées</span></legend>
					<span class="entree">
						<label class="entree_n" for="mail"><span class="degrade1">Votre mail</span></label>
						<input class="entree_n" type="email" name="mail" id="mail" placeholder="visiteur@gmail.com" required />
					</span>
					<span class="entree">
						<label class="entree_n" for="discord"><span class="degrade1">Votre ID discord</span></label>
						<input class="entree_n" type="text" name="discord" id="discord" placeholder="ChatNoir#12345" />
					</span>
					<span class="entree">
						<label class="entree_n" for="pseudo"><span class="degrade1">Votre peuso</span></label>
						<input class="entree_n" type="text" name="pseudo" id="pseudo" placeholder="Chat Noir" required /> 
					</span>
					<span class="entree">
						<label class="entree_n" for="demande"><span class="degrade1">Votre demande</span></label>
						<textarea  class="entree_n" name="demande" id="demande" placeholder="exemple: Mon personnage avec tel vetement dans tel pose" rows="5" cols="20"></textarea>
					</span>
				</fieldset>
			</fieldset>

		<!--ZONE 2-->

			<fieldset class="dessin">
				<legend><span class="degrade1">Le dessin</span></legend>
				<!--CHOIX 1-->	
				<fieldset class="choix">
					<legend><span class="degrade1">Style</span></legend>
					<span class="zone_case">
						<span class="case">
							<span class="case_t">
								<input type="radio" name="style" class="case_n" id="radio-a" checked  required>
								<label class="case_n" for="radio-a"><span class="degrade1">Normal</span></label>
							</span>
							<span class="case_t">
								<input type="radio" name="style" class="case_n" id="radio-b"   >
								<label class="case_n" for="radio-b"><span class="degrade1">Chibi</span></label>
							</span>
						</span>
					</span>
				</fieldset>
				<!--CHOIX 2-->			
				<fieldset class="choix">
					<legend><span class="degrade1">Format</span></legend>
					<span class="zone_case">
						<span class="case_t">
							<input type="radio" name="format" class="case_n" id="radio-c" checked  required>
							<label class="case_n" for="radio-c"><span class="degrade1">Full Body</span></label>
						</span>
						<span class="case_t">
							<input type="radio" name="format" class="case_n" id="radio-d"   >
							<label class="case_n" for="radio-d"><span class="degrade1">Thigh-up</span></label>
						</span>
						<span class="case_t">
							<input type="radio" name="format" class="case_n" id="radio-e"	>
							<label class="case_n" for="radio-e"><span class="degrade1">Bust-up</span></label>
						</span>
						<span class="case_t">
							<input type="radio" name="format" class="case_n" id="radio-f"   >
							<label class="case_n" for="radio-f"><span class="degrade1">Half Body</span></label>
						</span>
					</span>
				</fieldset>
				<!--CHOIX 3-->			
				<fieldset class="choix">
					<legend><span class="degrade1">Rendu</span></legend>
					<span class="zone_case">
						<span class="case">
							<span class="case_t">
								<input type="radio" name="rendu" class="case_n" id="radio-g" checked  required>
								<label class="case_n" for="radio-g"><span class="degrade1">Full Shade</span></label>
							</span>
							<span class="case_t">
								<input type="radio" name="rendu" class="case_n" id="radio-h"   >
								<label class="case_n" for="radio-h"><span class="degrade1">Sketch + Shade</span></label>
							</span>
							<span class="case_t">
								<input type="radio" name="rendu" class="case_n" id="radio-i"	>
								<label class="case_n" for="radio-i"><span class="degrade1">Sketch</span></label>
							</span>
						</span>
					</span>
				</fieldset>
				<!--CHOIX 4-->	
				<fieldset class="choix">
					<legend><span class="degrade1">Extra</span></legend>
					<span class="box">	
						<span class="box_t">
							<input type="checkbox" name="backgrounddetails" id="bgd" class="box_n">
							<label for="bgd" class="box_n"><span class="degrade1">Background détails</span></label>
						</span>
						<span class="box_t">			
							<input type="checkbox" name="backgroundsimple" id="bgs" class="box_n">
							<label for="bgs" class="box_n"><span class="degrade1">Background simple</span></label>
						</span>
						<span class="box_t">
							<input type="checkbox" name="petsdetaillé" id="petd" class="box_n">
							<label for="petd" class="box_n"><span class="degrade1">Pets détaillé</span></label>
						</span>		
						<span class="box_t">
							<input type="checkbox" name="petssimple" id="pets" class="box_n">
							<label for="pets" class="box_n"><span class="degrade1">Pets simple</span></label>
						</span>
						<span class="box_t">
							<input type="checkbox" name="petssimple" id="propsd" class="box_n">
							<label for="propsd" class="box_n"><span class="degrade1">Props détaillé</span></label>
						</span>			
						<span class="box_t">
							<input type="checkbox" name="petssimple" id="propss" class="box_n">
							<label for="propss" class="box_n"><span class="degrade1">Props simple</span></label>
						</span>
					</span>
				</fieldset>
				<!--CHOIX 5-->			
				<fieldset class="choix">
				<legend><span class="degrade1">Taille</span></legend>
					<select class="liste" name="taille" id="taille" > 
						<option value="emote" >Emote</option>
						<option value="avatar">Avatar</option>
						<option value="small">Small</option>
						<option value="medium">Medium</option>
						<option value="large">Large</option>
						<option value="poster">Poster</option>
						<option value="vecteur">Vecteur</option>
					</select>
				</fieldset>
			</fieldset>

		<!--ZONE 3-->
			<fieldset class="zone_envoi">
			<legend><span class="degrade1">Envoyer</span></legend>
				<input type="submit" value="Valider" class="envoi_bouton" />
			</fieldset>
	</form>
