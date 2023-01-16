<script lang="ts">
	import Email from '$lib/icons/Email.svelte';
	import Github from '$lib/icons/Github.svelte';
</script>

<footer>
	<h3>Kontakt</h3>
	<p><i>Udviklere kan kontaktes ved</i></p>
	<p>
		<a href="mailto:emil148p@zbc.dk">
			<Email />
			emil148p@zbc.dk
		</a>
	</p>

	<p>
		<a href="mailto:linu0108@zbc.dk">
			<Email />
			linu0108@zbc.dk
		</a>
	</p>
	<br />

	<h3>Source koden kan findes her</h3>
	<a href="https://github.com/LinusTM/inventory-system">
		<Github />
		github.com/LinusTM/inventory-system
	</a>
	<br />
	<br />

	<h3>
		<i>ZBC Ringsted: 2022 - {new Date().getFullYear()}</i>
	</h3>
</footer>

<style lang="scss">
	footer {
		padding: 1.5em;
		font-size: 1rem;
		background-color: var(--background-secondary);
		color: var(--text-primary);

		a {
			color: var(--text-primary);
		}

		a:hover {
			border-bottom: 2px solid var(--text-primary);
		}
	}
</style>
